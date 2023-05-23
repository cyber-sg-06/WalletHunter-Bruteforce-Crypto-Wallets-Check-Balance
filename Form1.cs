using NBitcoin;
using Nethereum.HdWallet;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace WalletHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine(DateTime.Now + " # start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();


            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public class ExplorerList
        {
            public string name { get; set; }
            public string urlprefix { get; set; }
            public string apikey { get; set; }
        }

        public class Exp
        {
            public int explorercount { get; set; }
            public List<ExplorerList> explorerList { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count > 0)
            {



                Console.WriteLine(DateTime.Now + " # Loading Explorer Config");
                try
                {

                    int length = listView1.Items.Count;


                    for (int i = 0; i < length; i++)
                    {

                        Console.WriteLine(DateTime.Now + " # Name: " + listView1.Items[i].SubItems[0].Text + " Url: " + listView1.Items[i].SubItems[1].Text + " Api: " + listView1.Items[i].SubItems[2].Text);

                    }

                }

                catch
                {

                }
                button4.Enabled = true;
                button6.Enabled = true;

                Console.WriteLine(DateTime.Now + " # Explorer Config Successfully Loaded");
            }
            else
            {
                MessageBox.Show("Add Chain Data First");
            }

        }
        public class Result
        {
            public string account { get; set; }
            public float balance { get; set; }
        }
        public class ExplorerInfo
        {
            public string status { get; set; }
            public string message { get; set; }
            public List<Result> result { get; set; }
        }

        public string GenerateMnemonic()
        {
            Mnemonic mnemogen = new Mnemonic(Wordlist.English, WordCount.Twelve);
            return mnemogen.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            float balance = 0;
            int loop = 0;
            string balancefound = "";
            DateTime startTime, endTime;
            startTime = DateTime.Now;


            try
            {
                while (1 > 0 && button5.Enabled == true)
                {
                    string[] mnemo = new string[100];
                    string[] address = new string[100];
                    string[] privatekey = new string[100];
                    float[] explorerResult1 = new float[100];
                    float[] explorerResult2 = new float[100];
                    float[] explorerResult3 = new float[100];
                    float[] explorerResult4 = new float[100];
                    float[] explorerResult5 = new float[100];
                    float[] explorerResult6 = new float[100];
                    float[] explorerResult7 = new float[100];
                    float[] explorerResult8 = new float[100];
                    float[] explorerResult9 = new float[100];
                    float[] explorerResult10 = new float[100];
                    if (loop > 0)
                    {
                        endTime = DateTime.Now;
                        Double elapsedSecs = ((TimeSpan)(endTime - startTime)).TotalSeconds;
                        Console.WriteLine(DateTime.Now + " # No Luck at Batch: " + (loop));
                        Console.WriteLine(DateTime.Now + " # Average Wallet Check Rate: " + (loop * 100) / (elapsedSecs) + " Wallet per Second");
                    }



                    Console.WriteLine(DateTime.Now + " # Generating " + (loop * 100) + " - " + ((loop + 1) * 100) + " Mnemonic & Address & Private Keys");
                    if (balance > 0)
                    {

                        try
                        {
                            FileStream fs2 = new FileStream(@Path.GetDirectoryName(Application.ExecutablePath) + "\\walletdata.txt", FileMode.Append);

                            TextWriter sw2 = new StreamWriter(fs2);
                            sw2.WriteLine(balancefound);
                            sw2.Close();

                            balance = 0;
                        }
                        catch
                        {

                        }
                    }
                    for (int i = 0; i < 100; i++)
                    {
                        mnemo[i] = GenerateMnemonic();
                        var wallet = new Wallet(mnemo[i], "");
                        var account = wallet.GetAccount(0);
                        address[i] = new Account(account.PrivateKey).Address;
                        privatekey[i] = account.PrivateKey;
                        wallet = null;
                        account = null;
                    }
                    Console.WriteLine(DateTime.Now + " # " + (loop * 100) + " - " + ((loop + 1) * 100) + " Wallet Batch Generated");

                    if (listView1.Items.Count == 1)
                    {


                        for (int s = 0; s < 5; s++)
                        {
                            Console.WriteLine(DateTime.Now + " # Checking Balances: " + ((loop * 100) + (s * 20)) + " - " + ((loop * 100) + ((s + 1) * 20)) + " Address Batch");
                            string url = listView1.Items[0].SubItems[1].Text +
                                            "?module=account&action=balancemulti&address=" +
                                            address[s * 20 + 0] + "," +
                                            address[s * 20 + 1] + "," +
                                            address[s * 20 + 2] + "," +
                                            address[s * 20 + 3] + "," +
                                            address[s * 20 + 4] + "," +
                                            address[s * 20 + 5] + "," +
                                            address[s * 20 + 6] + "," +
                                            address[s * 20 + 7] + "," +
                                            address[s * 20 + 8] + "," +
                                            address[s * 20 + 9] + "," +
                                            address[s * 20 + 10] + "," +
                                            address[s * 20 + 11] + "," +
                                            address[s * 20 + 12] + "," +
                                            address[s * 20 + 13] + "," +
                                            address[s * 20 + 14] + "," +
                                            address[s * 20 + 15] + "," +
                                           address[s * 20 + 16] + "," +
                                            address[s * 20 + 17] + "," +
                                            address[s * 20 + 18] + "," +
                                            address[s * 20 + 19] +
                                            "&tag=latest&apikey=" + listView1.Items[0].SubItems[2].Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri(url);
                            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            var result = response.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass = JsonConvert.DeserializeObject<ExplorerInfo>(result);
                            for (int j = 0; j < 20; j++)
                            {

                                explorerResult1[s * 20 + j] = myDeserializedClass.result[j].balance / 1000000000000000000;



                            }



                        }

                    }
                    if (listView1.Items.Count == 2)
                    {
                        for (int s = 0; s < 5; s++)
                        {
                            Console.WriteLine(DateTime.Now + " # Checking Balances: " + ((loop * 100) + (s * 20)) + " - " + ((loop * 100) + ((s + 1) * 20)) + " Address Batch");

                            string url = listView1.Items[0].SubItems[1].Text +
                                            "?module=account&action=balancemulti&address=" +
                                            address[s * 20 + 0] + "," +
                                            address[s * 20 + 1] + "," +
                                            address[s * 20 + 2] + "," +
                                            address[s * 20 + 3] + "," +
                                            address[s * 20 + 4] + "," +
                                            address[s * 20 + 5] + "," +
                                            address[s * 20 + 6] + "," +
                                            address[s * 20 + 7] + "," +
                                            address[s * 20 + 8] + "," +
                                            address[s * 20 + 9] + "," +
                                            address[s * 20 + 10] + "," +
                                            address[s * 20 + 11] + "," +
                                            address[s * 20 + 12] + "," +
                                            address[s * 20 + 13] + "," +
                                            address[s * 20 + 14] + "," +
                                            address[s * 20 + 15] + "," +
                                           address[s * 20 + 16] + "," +
                                            address[s * 20 + 17] + "," +
                                            address[s * 20 + 18] + "," +
                                            address[s * 20 + 19] +
                                            "&tag=latest&apikey=" + listView1.Items[0].SubItems[2].Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri(url);
                            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            var result = response.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass = JsonConvert.DeserializeObject<ExplorerInfo>(result);
                            string url1 = listView1.Items[1].SubItems[1].Text +
                "?module=account&action=balancemulti&address=" +
                address[s * 20 + 0] + "," +
                address[s * 20 + 1] + "," +
                address[s * 20 + 2] + "," +
                address[s * 20 + 3] + "," +
                address[s * 20 + 4] + "," +
                address[s * 20 + 5] + "," +
                address[s * 20 + 6] + "," +
                address[s * 20 + 7] + "," +
                address[s * 20 + 8] + "," +
                address[s * 20 + 9] + "," +
                address[s * 20 + 10] + "," +
                address[s * 20 + 11] + "," +
                address[s * 20 + 12] + "," +
                address[s * 20 + 13] + "," +
                address[s * 20 + 14] + "," +
                address[s * 20 + 15] + "," +
               address[s * 20 + 16] + "," +
                address[s * 20 + 17] + "," +
                address[s * 20 + 18] + "," +
                address[s * 20 + 19] +
                "&tag=latest&apikey=" + listView1.Items[1].SubItems[2].Text;

                            HttpClient client1 = new HttpClient();
                            client1.BaseAddress = new Uri(url1);
                            client1.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response1 = client1.GetAsync(url1).Result;
                            var result1 = response1.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass1 = JsonConvert.DeserializeObject<ExplorerInfo>(result1);


                            for (int j = 0; j < 20; j++)
                            {

                                explorerResult1[s * 20 + j] = myDeserializedClass.result[j].balance / 1000000000000000000;
                                explorerResult2[s * 20 + j] = myDeserializedClass1.result[j].balance / 1000000000000000000;



                            }



                        }


                    }
                    if (listView1.Items.Count == 3)
                    {


                    }
                    if (listView1.Items.Count == 4)
                    {

                    }
                    if (listView1.Items.Count == 5)
                    {

                    }
                    if (listView1.Items.Count == 6)
                    {

                    }
                    if (listView1.Items.Count == 7)
                    {

                    }
                    if (listView1.Items.Count == 8)
                    {

                    }
                    if (listView1.Items.Count == 9)
                    {

                    }
                    if (listView1.Items.Count == 10)
                    {

                    }



                    if (listView1.Items.Count == 1)
                    {
                        for (int k = 0; k < 100; k++)
                        {

                            if (explorerResult1[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[0].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k]);
                                balance = explorerResult1[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n" +
                                listView1.Items[0].SubItems[0].Text + " Balance : " + balance + "\n";


                            }
                            else
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[0].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 2)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[1].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k]);
                                balance = explorerResult1[k] + explorerResult2[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {
                                Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k]);
                            }
                        }


                    }
                    if (listView1.Items.Count == 3)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[2].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {

                                Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[2].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k]);

                            }
                        }

                    }
                    if (listView1.Items.Count == 4)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                 listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[2].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[3].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {

                                Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[2].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[3].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 5)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0 | explorerResult5[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                  listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[2].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[3].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[4].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k] + explorerResult5[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {

                                Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[0].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[1].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[2].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[3].SubItems[0].Text + " Balance : 0\n" +
                                    listView1.Items[4].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 6)
                    {


                        for (int k = 0; k < 100; k++)
                        {
                            int i = 5;
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0 | explorerResult5[k] > 0 | explorerResult6[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                 listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k] + explorerResult5[k] + explorerResult6[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {

                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 7)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            int i = 6;
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0 | explorerResult5[k] > 0 | explorerResult6[k] > 0 | explorerResult7[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k] + explorerResult5[k] + explorerResult6[k] + explorerResult7[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {

                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 8)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            int i = 7;
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0 | explorerResult5[k] > 0 | explorerResult6[k] > 0 | explorerResult7[k] > 0 | explorerResult8[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                 listView1.Items[i - 7].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k], explorerResult8[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k] + explorerResult5[k] + explorerResult6[k] + explorerResult7[k] + explorerResult8[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 7].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k], explorerResult8[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 9)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            int i = 8;
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0 | explorerResult5[k] > 0 | explorerResult6[k] > 0 | explorerResult7[k] > 0 | explorerResult8[k] > 0 | explorerResult9[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                  listView1.Items[i - 8].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 7].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k], explorerResult8[k], explorerResult9[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k] + explorerResult5[k] + explorerResult6[k] + explorerResult7[k] + explorerResult8[k] + explorerResult9[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                "Mnemonic : " + mnemo[k] + "\n" +
                                "Address : " + address[k] + "\n" +
                                "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 8].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 7].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k], explorerResult8[k], explorerResult9[k]);
                            }

                        }
                    }
                    if (listView1.Items.Count == 10)
                    {

                        for (int k = 0; k < 100; k++)
                        {
                            int i = 9;
                            if (explorerResult1[k] > 0 | explorerResult2[k] > 0 | explorerResult3[k] > 0 | explorerResult4[k] > 0 | explorerResult5[k] > 0 | explorerResult6[k] > 0 | explorerResult7[k] > 0 | explorerResult8[k] > 0 | explorerResult9[k] > 0 | explorerResult10[k] > 0)
                            {
                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 9].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 8].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 7].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k], explorerResult8[k], explorerResult9[k], explorerResult10[k]);
                                balance = explorerResult1[k] + explorerResult2[k] + explorerResult3[k] + explorerResult4[k] + explorerResult5[k] + explorerResult6[k] + explorerResult7[k] + explorerResult8[k] + explorerResult9[k] + explorerResult10[k];
                                balancefound = balancefound + "Account index : " + (loop * 100) + k + 1 + "\n" +
                                                            "Mnemonic : " + mnemo[k] + "\n" +
                                                            "Address : " + address[k] + "\n" +
                                                            "Private key : " + privatekey[k] + "\n";


                            }

                            else
                            {

                                Console.WriteLine(
                                "Account index : {0}\n" +
                                "Mnemonic : {1}\n" +
                                "Address : {2}\n" +
                                "Private key : {3}\n" +
                                listView1.Items[i - 9].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 8].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 7].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 6].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 5].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 4].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 3].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 2].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i - 1].SubItems[0].Text + " Balance : 0\n" +
                                listView1.Items[i].SubItems[0].Text + " Balance : 0\n", (loop * 100) + k + 1, mnemo[k], address[k], privatekey[k], explorerResult1[k], explorerResult2[k], explorerResult3[k], explorerResult4[k], explorerResult5[k], explorerResult6[k], explorerResult7[k], explorerResult8[k], explorerResult9[k], explorerResult10[k]);
                            }

                        }
                    }






                    mnemo = null;
                    address = null;
                    privatekey = null;
                    explorerResult1 = null;
                    explorerResult2 = null;
                    explorerResult3 = null;
                    explorerResult4 = null;
                    explorerResult5 = null;
                    explorerResult6 = null;
                    explorerResult7 = null;
                    explorerResult8 = null;
                    explorerResult9 = null;
                    explorerResult10 = null;

                    loop++;



                }
            }
            catch { }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string[] row = { textBox1.Text, textBox2.Text, textBox3.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                button3.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fill Name, URL and Api Fields");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem eachItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(eachItem);
                }
                if (listView1.Items.Count == 0)
                {
                    button3.Enabled = false;
                    button1.Enabled = false;
                    button4.Enabled = false;
                }
            }
            catch
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Console.WriteLine(DateTime.Now + " # Stopped");
            button5.Enabled = false;
        }
        int addresscountworker1 = 0;
        int addresscountworker2 = 0;
        int addresscountworker3 = 0;
        int addresscountworker4 = 0;



        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;


            if (textBox4.Text == "1")
            {
                walletGenerator1.RunWorkerAsync();
            }
            if (textBox4.Text == "2")
            {
                walletGenerator1.RunWorkerAsync();
                wait(3000);
                walletGenerator2.RunWorkerAsync();
            }
            if (textBox4.Text == "3")
            {
                walletGenerator1.RunWorkerAsync();
                wait(3000);
                walletGenerator2.RunWorkerAsync();
                wait(6000);
                walletGenerator3.RunWorkerAsync();
            }
            if (textBox4.Text == "4")
            {
                walletGenerator1.RunWorkerAsync();
                wait(3000);
                walletGenerator2.RunWorkerAsync();
                wait(6000);
                walletGenerator3.RunWorkerAsync();
                wait(9000);
                walletGenerator4.RunWorkerAsync();
            }



        }




        int loop = 0;
        bool worker1started = false;
        bool worker2started = false;
        bool worker3started = false;
        bool worker4started = false;

        private void walletGenerator1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (button5.Enabled == true)
            {
                worker1started = false;
                string[] mnemo = new string[20];
                string[] address = new string[20];
                string[] privatekey = new string[20];
                for (int i = 0; i < 20; i++)
                {

                    mnemo[i] = GenerateMnemonic();
                    mnemonicBox.Items.Add(mnemo[i]);
                    var wallet = new Wallet(mnemo[i], "");
                    var account = wallet.GetAccount(0);
                    address[i] = new Account(account.PrivateKey).Address;
                    privatekey[i] = account.PrivateKey;
                    addressBox.Items.Add(address[i]);
                    privatekeyBox.Items.Add(privatekey[i]);
                    wallet = null;
                    account = null;
                    addresscountworker1++;
                    addressCountLabel1.Text = addresscountworker1.ToString();
                }
                mnemo = null;
                address = null;
                privatekey = null;
                while (worker2started == true | worker3started == true | worker4started == true)
                {
                    Application.DoEvents();
                }

                try
                {
                    for (int t = 0; t < listView1.Items.Count; t++)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            worker1started = true;
                            float[] explorerResult1 = new float[20];
                            Console.WriteLine(DateTime.Now + " # Checking Balances: " + (loop * 20) + " - " + (loop + 1) * 20 + " Address Batch");

                            string url = listView1.Items[t].SubItems[1].Text +
                                            "?module=account&action=balancemulti&address=" +
                                            addressBox.Items[i * 20 + 0] + "," +
                                            addressBox.Items[i * 20 + 1] + "," +
                                            addressBox.Items[i * 20 + 2] + "," +
                                            addressBox.Items[i * 20 + 3] + "," +
                                            addressBox.Items[i * 20 + 4] + "," +
                                            addressBox.Items[i * 20 + 5] + "," +
                                            addressBox.Items[i * 20 + 6] + "," +
                                            addressBox.Items[i * 20 + 7] + "," +
                                            addressBox.Items[i * 20 + 8] + "," +
                                            addressBox.Items[i * 20 + 9] + "," +
                                            addressBox.Items[i * 20 + 10] + "," +
                                            addressBox.Items[i * 20 + 11] + "," +
                                            addressBox.Items[i * 20 + 12] + "," +
                                            addressBox.Items[i * 20 + 13] + "," +
                                            addressBox.Items[i * 20 + 14] + "," +
                                            addressBox.Items[i * 20 + 15] + "," +
                                            addressBox.Items[i * 20 + 16] + "," +
                                            addressBox.Items[i * 20 + 17] + "," +
                                            addressBox.Items[i * 20 + 18] + "," +
                                            addressBox.Items[i * 20 + 19] +
                                            "&tag=latest&apikey=" + listView1.Items[t].SubItems[2].Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri(url);
                            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            var result = response.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass = JsonConvert.DeserializeObject<ExplorerInfo>(result);
                            float balance;
                            string balancefound = "";
                            for (int j = 0; j < 20; j++)
                            {
                                explorerResult1[i * 20 + j] = myDeserializedClass.result[j].balance / 1000000000000000000;
                                if (explorerResult1[i * 20 + j] > 0)
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : {4}\n", (loop * 20) + i * 20 + j + 1, mnemonicBox.Items[i * 20 + j], addressBox.Items[i * 20 + j], privatekeyBox.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                    balance = explorerResult1[i * 20 + j];
                                    balancefound = balancefound + "Account index : " + (loop * 20) + i * 20 + j + 1 + "\n" +
                                    "Mnemonic : " + mnemonicBox.Items[i * 20 + j] + "\n" +
                                    "Address : " + addressBox.Items[i * 20 + j] + "\n" +
                                    "Private key : " + privatekeyBox.Items[i * 20 + j] + "\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : " + balance + "\n";
                                    FileStream fs2 = new FileStream(@Path.GetDirectoryName(Application.ExecutablePath) + "\\walletdata.txt", FileMode.Append);

                                    TextWriter sw2 = new StreamWriter(fs2);
                                    sw2.WriteLine(balancefound);
                                    sw2.Close();

                                    balance = 0;
                                    foundBox.Items.Add(balancefound);

                                }
                                else
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : 0\n", (loop * 20) + i * 20 + j + 1, mnemonicBox.Items[i * 20 + j], addressBox.Items[i * 20 + j], privatekeyBox.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                }

                            }
                            explorerResult1 = null;


                        }
                    }


                }
                catch
                {


                }


                addressBox.Items.Clear();
                privatekeyBox.Items.Clear();
                mnemonicBox.Items.Clear();
                addresscountworker1 = addresscountworker1 - 20;
                loop++;


            }
        }

        private void walletGenerator2_DoWork(object sender, DoWorkEventArgs e)
        {

            while (button5.Enabled == true)
            {
                worker2started = false;
                string[] mnemo = new string[20];
                string[] address = new string[20];
                string[] privatekey = new string[20];
                for (int i = 0; i < 20; i++)
                {
                    mnemo[i] = GenerateMnemonic();
                    mnemonicBox1.Items.Add(mnemo[i]);
                    var wallet = new Wallet(mnemo[i], "");
                    var account = wallet.GetAccount(0);
                    address[i] = new Account(account.PrivateKey).Address;
                    privatekey[i] = account.PrivateKey;
                    addressBox1.Items.Add(address[i]);
                    privatekeyBox1.Items.Add(privatekey[i]);
                    wallet = null;
                    account = null;
                    addresscountworker2++;
                    addressCountLabel2.Text = addresscountworker2.ToString();
                }
                mnemo = null;
                address = null;
                privatekey = null;
                while (worker1started == true | worker3started == true | worker4started == true)
                {
                    Application.DoEvents();
                }

                try
                {

                    for (int t = 0; t < listView1.Items.Count; t++)
                    {

                        for (int i = 0; i < 1; i++)
                        {
                            worker2started = true;


                            float[] explorerResult1 = new float[20];



                            Console.WriteLine(DateTime.Now + " # Checking Balances: " + (loop * 20) + " - " + (loop + 1) * 20 + " Address Batch");

                            string url = listView1.Items[t].SubItems[1].Text +
                                            "?module=account&action=balancemulti&address=" +
                                            addressBox1.Items[i * 20 + 0] + "," +
                                            addressBox1.Items[i * 20 + 1] + "," +
                                            addressBox1.Items[i * 20 + 2] + "," +
                                            addressBox1.Items[i * 20 + 3] + "," +
                                            addressBox1.Items[i * 20 + 4] + "," +
                                            addressBox1.Items[i * 20 + 5] + "," +
                                            addressBox1.Items[i * 20 + 6] + "," +
                                            addressBox1.Items[i * 20 + 7] + "," +
                                            addressBox1.Items[i * 20 + 8] + "," +
                                            addressBox1.Items[i * 20 + 9] + "," +
                                            addressBox1.Items[i * 20 + 10] + "," +
                                            addressBox1.Items[i * 20 + 11] + "," +
                                            addressBox1.Items[i * 20 + 12] + "," +
                                            addressBox1.Items[i * 20 + 13] + "," +
                                            addressBox1.Items[i * 20 + 14] + "," +
                                            addressBox1.Items[i * 20 + 15] + "," +
                                            addressBox1.Items[i * 20 + 16] + "," +
                                            addressBox1.Items[i * 20 + 17] + "," +
                                            addressBox1.Items[i * 20 + 18] + "," +
                                            addressBox1.Items[i * 20 + 19] +
                                            "&tag=latest&apikey=" + listView1.Items[t].SubItems[2].Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri(url);
                            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            var result = response.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass = JsonConvert.DeserializeObject<ExplorerInfo>(result);
                            float balance;
                            string balancefound = "";
                            for (int j = 0; j < 20; j++)
                            {
                                explorerResult1[i * 20 + j] = myDeserializedClass.result[j].balance / 1000000000000000000;
                                if (explorerResult1[i * 20 + j] > 0)
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : {4}\n", (loop * 20) + i * 20 + j + 1, mnemonicBox1.Items[i * 20 + j], addressBox1.Items[i * 20 + j], privatekeyBox1.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                    balance = explorerResult1[i * 20 + j];
                                    balancefound = balancefound + "Account index : " + (loop * 20) + i * 20 + j + 1 + "\n" +
                                    "Mnemonic : " + mnemonicBox1.Items[i * 20 + j] + "\n" +
                                    "Address : " + addressBox1.Items[i * 20 + j] + "\n" +
                                    "Private key : " + privatekeyBox1.Items[i * 20 + j] + "\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : " + balance + "\n";
                                    FileStream fs2 = new FileStream(@Path.GetDirectoryName(Application.ExecutablePath) + "\\walletdata.txt", FileMode.Append);

                                    TextWriter sw2 = new StreamWriter(fs2);
                                    sw2.WriteLine(balancefound);
                                    sw2.Close();

                                    balance = 0;
                                    foundBox.Items.Add(balancefound);

                                }
                                else
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : 0\n", (loop * 20) + i * 20 + j + 1, mnemonicBox1.Items[i * 20 + j], addressBox1.Items[i * 20 + j], privatekeyBox1.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                }

                            }
                            explorerResult1 = null;


                        }


                    }

                }
                catch
                {


                }
                addressBox1.Items.Clear();
                privatekeyBox1.Items.Clear();
                mnemonicBox1.Items.Clear();


                addresscountworker2 = addresscountworker2 - 20;


                loop++;


            }
        }

        private void walletGenerator3_DoWork(object sender, DoWorkEventArgs e)
        {
            while (button5.Enabled == true)
            {
                worker3started = false;
                string[] mnemo = new string[20];
                string[] address = new string[20];
                string[] privatekey = new string[20];
                for (int i = 0; i < 20; i++)
                {
                    mnemo[i] = GenerateMnemonic();
                    mnemonicBox2.Items.Add(mnemo[i]);
                    var wallet = new Wallet(mnemo[i], "");
                    var account = wallet.GetAccount(0);
                    address[i] = new Account(account.PrivateKey).Address;
                    privatekey[i] = account.PrivateKey;
                    addressBox2.Items.Add(address[i]);
                    privatekeyBox2.Items.Add(privatekey[i]);
                    wallet = null;
                    account = null;
                    addresscountworker3++;
                    addressCountLabel3.Text = addresscountworker3.ToString();
                }
                mnemo = null;
                address = null;
                privatekey = null;
                while (worker1started == true | worker2started == true | worker4started == true)
                {
                    Application.DoEvents();
                }

                try
                {
                    for (int t = 0; t < listView1.Items.Count; t++)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            worker3started = true;
                            float[] explorerResult1 = new float[20];



                            Console.WriteLine(DateTime.Now + " # Checking Balances: " + (loop * 20) + " - " + (loop + 1) * 20 + " Address Batch");

                            string url = listView1.Items[t].SubItems[1].Text +
                                            "?module=account&action=balancemulti&address=" +
                                            addressBox2.Items[i * 20 + 0] + "," +
                                            addressBox2.Items[i * 20 + 1] + "," +
                                            addressBox2.Items[i * 20 + 2] + "," +
                                            addressBox2.Items[i * 20 + 3] + "," +
                                            addressBox2.Items[i * 20 + 4] + "," +
                                            addressBox2.Items[i * 20 + 5] + "," +
                                            addressBox2.Items[i * 20 + 6] + "," +
                                            addressBox2.Items[i * 20 + 7] + "," +
                                            addressBox2.Items[i * 20 + 8] + "," +
                                            addressBox2.Items[i * 20 + 9] + "," +
                                            addressBox2.Items[i * 20 + 10] + "," +
                                            addressBox2.Items[i * 20 + 11] + "," +
                                            addressBox2.Items[i * 20 + 12] + "," +
                                            addressBox2.Items[i * 20 + 13] + "," +
                                            addressBox2.Items[i * 20 + 14] + "," +
                                            addressBox2.Items[i * 20 + 15] + "," +
                                            addressBox2.Items[i * 20 + 16] + "," +
                                            addressBox2.Items[i * 20 + 17] + "," +
                                            addressBox2.Items[i * 20 + 18] + "," +
                                            addressBox2.Items[i * 20 + 19] +
                                            "&tag=latest&apikey=" + listView1.Items[t].SubItems[2].Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri(url);
                            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            var result = response.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass = JsonConvert.DeserializeObject<ExplorerInfo>(result);
                            float balance;
                            string balancefound = "";
                            for (int j = 0; j < 20; j++)
                            {
                                explorerResult1[i * 20 + j] = myDeserializedClass.result[j].balance / 1000000000000000000;
                                if (explorerResult1[i * 20 + j] > 0)
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : {4}\n", (loop * 20) + i * 20 + j + 1, mnemonicBox2.Items[i * 20 + j], addressBox2.Items[i * 20 + j], privatekeyBox2.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                    balance = explorerResult1[i * 20 + j];
                                    balancefound = balancefound + "Account index : " + (loop * 20) + i * 20 + j + 1 + "\n" +
                                    "Mnemonic : " + mnemonicBox2.Items[i * 20 + j] + "\n" +
                                    "Address : " + addressBox2.Items[i * 20 + j] + "\n" +
                                    "Private key : " + privatekeyBox2.Items[i * 20 + j] + "\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : " + balance + "\n";
                                    FileStream fs2 = new FileStream(@Path.GetDirectoryName(Application.ExecutablePath) + "\\walletdata.txt", FileMode.Append);

                                    TextWriter sw2 = new StreamWriter(fs2);
                                    sw2.WriteLine(balancefound);
                                    sw2.Close();

                                    balance = 0;
                                    foundBox.Items.Add(balancefound);

                                }
                                else
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : 0\n", (loop * 20) + i * 20 + j + 1, mnemonicBox2.Items[i * 20 + j], addressBox2.Items[i * 20 + j], privatekeyBox2.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                }

                            }
                            explorerResult1 = null;


                        }
                    }
                }
                catch
                {


                }


                addressBox2.Items.Clear();
                privatekeyBox2.Items.Clear();
                mnemonicBox2.Items.Clear();


                addresscountworker3 = addresscountworker3 - 20;


                loop++;


            }
        }

        private void walletGenerator4_DoWork(object sender, DoWorkEventArgs e)
        {
            while (button5.Enabled == true)
            {
                worker4started = false;
                string[] mnemo = new string[20];
                string[] address = new string[20];
                string[] privatekey = new string[20];
                for (int i = 0; i < 20; i++)
                {
                    mnemo[i] = GenerateMnemonic();
                    mnemonicBox3.Items.Add(mnemo[i]);
                    var wallet = new Wallet(mnemo[i], "");
                    var account = wallet.GetAccount(0);
                    address[i] = new Account(account.PrivateKey).Address;
                    privatekey[i] = account.PrivateKey;
                    addressBox3.Items.Add(address[i]);
                    privatekeyBox3.Items.Add(privatekey[i]);
                    wallet = null;
                    account = null;
                    addresscountworker4++;
                    addressCountLabel4.Text = addresscountworker4.ToString();
                }
                mnemo = null;
                address = null;
                privatekey = null;
                while (worker1started == true | worker2started == true | worker3started == true)
                {
                    Application.DoEvents();
                }

                try
                {
                    for (int t = 0; t < listView1.Items.Count; t++)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            worker4started = true;
                            float[] explorerResult1 = new float[20];



                            Console.WriteLine(DateTime.Now + " # Checking Balances: " + (loop * 20) + " - " + (loop + 1) * 20 + " Address Batch");

                            string url = listView1.Items[t].SubItems[1].Text +
                                            "?module=account&action=balancemulti&address=" +
                                            addressBox3.Items[i * 20 + 0] + "," +
                                            addressBox3.Items[i * 20 + 1] + "," +
                                            addressBox3.Items[i * 20 + 2] + "," +
                                            addressBox3.Items[i * 20 + 3] + "," +
                                            addressBox3.Items[i * 20 + 4] + "," +
                                            addressBox3.Items[i * 20 + 5] + "," +
                                            addressBox3.Items[i * 20 + 6] + "," +
                                            addressBox3.Items[i * 20 + 7] + "," +
                                            addressBox3.Items[i * 20 + 8] + "," +
                                            addressBox3.Items[i * 20 + 9] + "," +
                                            addressBox3.Items[i * 20 + 10] + "," +
                                            addressBox3.Items[i * 20 + 11] + "," +
                                            addressBox3.Items[i * 20 + 12] + "," +
                                            addressBox3.Items[i * 20 + 13] + "," +
                                            addressBox3.Items[i * 20 + 14] + "," +
                                            addressBox3.Items[i * 20 + 15] + "," +
                                            addressBox3.Items[i * 20 + 16] + "," +
                                            addressBox3.Items[i * 20 + 17] + "," +
                                            addressBox3.Items[i * 20 + 18] + "," +
                                            addressBox3.Items[i * 20 + 19] +
                                            "&tag=latest&apikey=" + listView1.Items[t].SubItems[2].Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri(url);
                            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            var result = response.Content.ReadAsStringAsync().Result;
                            ExplorerInfo myDeserializedClass = JsonConvert.DeserializeObject<ExplorerInfo>(result);
                            float balance;
                            string balancefound = "";
                            for (int j = 0; j < 20; j++)
                            {
                                explorerResult1[i * 20 + j] = myDeserializedClass.result[j].balance / 1000000000000000000;
                                if (explorerResult1[i * 20 + j] > 0)
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : {4}\n", (loop * 20) + i * 20 + j + 1, mnemonicBox3.Items[i * 20 + j], addressBox3.Items[i * 20 + j], privatekeyBox3.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                    balance = explorerResult1[i * 20 + j];
                                    balancefound = balancefound + "Account index : " + (loop * 20) + i * 20 + j + 1 + "\n" +
                                    "Mnemonic : " + mnemonicBox3.Items[i * 20 + j] + "\n" +
                                    "Address : " + addressBox3.Items[i * 20 + j] + "\n" +
                                    "Private key : " + privatekeyBox3.Items[i * 20 + j] + "\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : " + balance + "\n";
                                    FileStream fs2 = new FileStream(@Path.GetDirectoryName(Application.ExecutablePath) + "\\walletdata.txt", FileMode.Append);

                                    TextWriter sw2 = new StreamWriter(fs2);
                                    sw2.WriteLine(balancefound);
                                    sw2.Close();

                                    balance = 0;
                                    foundBox.Items.Add(balancefound);

                                }
                                else
                                {

                                    Console.WriteLine(
                                    "Account index : {0}\n" +
                                    "Mnemonic : {1}\n" +
                                    "Address : {2}\n" +
                                    "Private key : {3}\n" +
                                    listView1.Items[t].SubItems[0].Text + " Balance : 0\n", (loop * 20) + i * 20 + j + 1, mnemonicBox3.Items[i * 20 + j], addressBox3.Items[i * 20 + j], privatekeyBox3.Items[i * 20 + j], explorerResult1[i * 20 + j]);
                                }

                            }
                            explorerResult1 = null;


                        }
                    }
                }
                catch
                {


                }



                addressBox3.Items.Clear();
                privatekeyBox3.Items.Clear();
                mnemonicBox3.Items.Clear();


                addresscountworker4 = addresscountworker4 - 20;


                loop++;


            }
        }


    }
}
