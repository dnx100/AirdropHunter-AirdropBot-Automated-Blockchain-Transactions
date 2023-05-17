using Nethereum.HdWallet;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirdropHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string rpc { get; set; }
        public static string accountname { get; set; }

        int privatekeycount = 0;
        public static string tempbalance { get; set; }
        public static int walletcount { get; set; }

        string[] accountprivatekey = new string[9999];

        string[] accountaddress = new string[9999];

        string[] accountbalance = new string[9999];

        int transferNativeBalancePercent = 0;
        int transferNativeBalanceLoop = 0;


        static string GetAccountAddress(string privatekey)
        {
            var account = new Account(privatekey);
            return account.Address;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (privateKeyMode.Checked == true)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                rpc = rpcURL.Text;
                if (privatekeycount == 1)
                {
                    accountprivatekey[privatekeycount - 1] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 2)
                {
                    accountprivatekey[privatekeycount - 2] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 3)
                {
                    accountprivatekey[privatekeycount - 3] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 4)
                {
                    accountprivatekey[privatekeycount - 4] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 4] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 4;
                    accountname = accountaddress[privatekeycount - 4];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 4] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 4];
                    accountprivatekey[privatekeycount - 3] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox4.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox4.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox4.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 5)
                {
                    accountprivatekey[privatekeycount - 5] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 5] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 5;
                    accountname = accountaddress[privatekeycount - 5];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 5] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 5];
                    accountprivatekey[privatekeycount - 4] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 4] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 4;
                    accountname = accountaddress[privatekeycount - 4];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 4] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 4];
                    accountprivatekey[privatekeycount - 3] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox4.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox4.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox4.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox5.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox5.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox5.Text = accountbalance[privatekeycount - 1];

                }
                if (privatekeycount == 6)
                {
                    accountprivatekey[privatekeycount - 6] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 6] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 6;
                    accountname = accountaddress[privatekeycount - 6];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 6] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 6];
                    accountprivatekey[privatekeycount - 5] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 5] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 5;
                    accountname = accountaddress[privatekeycount - 5];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 5] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 5];
                    accountprivatekey[privatekeycount - 4] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 4] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 4;
                    accountname = accountaddress[privatekeycount - 4];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 4] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 4];
                    accountprivatekey[privatekeycount - 3] = privateKeyBox4.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox4.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox4.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox5.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox5.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox5.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox6.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox6.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox6.Text = accountbalance[privatekeycount - 1];
                }

                while (loadAccountsFromPrivateKey.IsBusy == true)
                {
                    Application.DoEvents();
                }

                if (loadAccountsFromPrivateKey.IsBusy == false)
                {
                    loadAccountsFromPrivateKey.RunWorkerAsync();
                }
                while (loadAccountsFromPrivateKey.IsBusy == true)
                {
                    Application.DoEvents();
                }
                button3.Enabled = true;

            }

            if (seedMode.Checked == true)
            {

                privatekeycount = 0;
                var wallet = new Wallet(seedPhrase.Text, extraWord.Text);
                for (int i = 0; i < Convert.ToInt32(accountCount.Text); i++)
                {
                    var account = wallet.GetAccount(i);
                    accountaddress[i] = account.Address;
                    accountprivatekey[i] = account.PrivateKey;
                    privatekeycount++;
                }

                button3.Enabled = false;
                button1.Enabled = false;
                rpc = rpcURL.Text;

                for (int i = 0; i < Convert.ToInt32(accountCount.Text); i++)
                {
                    accountname = accountaddress[i];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[i] = tempbalance;

                }
                for (int i = 0; i < Convert.ToInt32(accountCount.Text); i++)
                {
                    Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                }

                button3.Enabled = true;




            }

            button1.Enabled = true;
        }

        private void seedMode_CheckedChanged(object sender, EventArgs e)
        {

            if (seedMode.Checked == true)
            {
                privateKeyMode.Checked = false;
                Console.WriteLine("Seed Mode Selected");
                Console.WriteLine("You Can Work With As Wanted As Accounts");
                tabControl3.SelectedTab = tabControl3.TabPages["tabPage3"];
                seedPhrase.Enabled = true; seedPhraseLabel.Enabled = true; extraWord.Enabled = true; extraWordLabel.Enabled = true; accountCount.Enabled = true; accountCountLabel.Enabled = true;

            }

            if (seedMode.Checked == false)
            {
                seedPhrase.Enabled = false; seedPhraseLabel.Enabled = false; extraWord.Enabled = false; extraWordLabel.Enabled = false; accountCount.Enabled = false; accountCountLabel.Enabled = false;
            }

            button3.Enabled = true;
        }

        private void privateKeyMode_CheckedChanged(object sender, EventArgs e)
        {

            if (privateKeyMode.Checked == true)
            {
                seedMode.Checked = false; Console.WriteLine("Private Key Mode Selected");
                Console.WriteLine("You Can Work Up To 6 Accounts");
                tabControl3.SelectedTab = tabControl3.TabPages["tabPage4"];
                privateKeyCheck1.Enabled = true;
            }
            if (privateKeyMode.Checked == false)
            {

                privateKeyCheck1.Enabled = false; privateKeyBox1.Enabled = false; balanceBox1.Enabled = false;
                privateKeyCheck2.Enabled = false; privateKeyBox2.Enabled = false; balanceBox2.Enabled = false;
                privateKeyCheck3.Enabled = false; privateKeyBox3.Enabled = false; balanceBox3.Enabled = false;
                privateKeyCheck4.Enabled = false; privateKeyBox4.Enabled = false; balanceBox4.Enabled = false;
                privateKeyCheck5.Enabled = false; privateKeyBox5.Enabled = false; balanceBox5.Enabled = false;
                privateKeyCheck6.Enabled = false; privateKeyBox6.Enabled = false; balanceBox6.Enabled = false;
            }
            button3.Enabled = true;

        }
        private void transferNativeBalanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transferNativeBalanceCheck.Checked == true)
            {
                Console.WriteLine("Transfer Native Balance Mode Selected");
                Console.WriteLine("Bot Will Transfer Native Balance (ETH, BNB, Matic, AVAX etc.) For Loaded Accounts In Order. Set Percent and Loop Count Correctly. This Process Will Take As Long As The Number Of Loop Count.");
                swapTokensCheck.Checked = false;
                transferTokensCheck.Checked = false;
                tabControl2.SelectedTab = tabControl2.TabPages["tabPage1"];
                nativeTransferLoop.Enabled = true; nativeTransferLoopLabel.Enabled = true; nativeTransferPercent.Enabled = true; nativeTransferPercentLabel.Enabled = true;

            }
            if (transferNativeBalanceCheck.Checked == false)

            {
                nativeTransferLoop.Enabled = false; nativeTransferLoopLabel.Enabled = false; nativeTransferPercent.Enabled = false; nativeTransferPercentLabel.Enabled = false;

            }


        }

        private void transferTokensCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transferTokensCheck.Checked == true)
            {
                Console.WriteLine("Transfer Tokens Mode Selected");
                Console.WriteLine("Bot Will Transfer Token Balances. You Can Define Token Contracts Up To 4. Set Percent and Loop Count Correctly. This Process Will Take As Long As The Number Of Loop Count.");
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                tabControl2.SelectedTab = tabControl2.TabPages["tabPage6"];
                enableTransferToken1.Enabled = true;
                transferTokenLoopCount.Enabled = true; transferTokenLoopCountLabel.Enabled = true;
            }
            if (transferTokensCheck.Checked == false)
            {
                enableTransferToken1.Enabled = false; enableTransferToken2.Enabled = false; enableTransferToken3.Enabled = false; enableTransferToken4.Enabled = false;
                transferContract1.Enabled = false; transferContract2.Enabled = false; transferContract3.Enabled = false; transferContract4.Enabled = false;
                transferPercentToken1.Enabled = false; transferPercentToken2.Enabled = false; transferPercentToken3.Enabled = false; transferPercentToken4.Enabled = false;
                transferBackToAccount1.Enabled = false; transferBackToAccount2.Enabled = false; transferBackToAccount3.Enabled = false; transferBackToAccount4.Enabled = false;
                transferBackToAccount1.Checked = false; transferBackToAccount2.Checked = false; transferBackToAccount3.Checked = false; transferBackToAccount4.Checked = false;
                transferTokenLoopCount.Enabled = false;
                transferContract1Label.Enabled = false; transferContract2Label.Enabled = false; transferContract3Label.Enabled = false; transferContract4Label.Enabled = false;
                transferPercentToken1Label.Enabled = false; transferPercentToken2Label.Enabled = false; transferPercentToken3Label.Enabled = false; transferPercentToken4Label.Enabled = false;
                transferTokenLoopCountLabel.Enabled = false;
                enableTransferToken1.Checked = false;
                enableTransferToken2.Checked = false;
                enableTransferToken3.Checked = false;
                enableTransferToken4.Checked = false;

            }
        }
        private void swapTokensCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (swapTokensCheck.Checked == true)
            {
                Console.WriteLine("Swap Tokens Mode Selected");
                Console.WriteLine("Bot Will Swap Tokens. You Can Define Token Contracts Up To 4. Set Router Contract, Percent, Loop Count And Slippage Correctly. Router Contract Differs For Every Network. This Process Will Take As Long As The Number Of Loop Count.");
                transferTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                tabControl2.SelectedTab = tabControl2.TabPages["tabPage7"];
                enableSwapToken1.Enabled = true; routerContractBox.Enabled = true; routerContractBoxLabel.Enabled = true;
                swapTokenSlippage.Enabled = true; swapTokenLoopCount.Enabled = true; swapTokenSlippageLabel.Enabled = true; swapTokenLoopCountLabel.Enabled = true;
            }
            if (swapTokensCheck.Checked == false)
            {
                enableSwapToken1.Enabled = false; enableSwapToken2.Enabled = false; enableSwapToken3.Enabled = false; enableSwapToken4.Enabled = false;
                routerContractBox.Enabled = false; swapContract1.Enabled = false; swapContract2.Enabled = false; swapContract3.Enabled = false; swapContract4.Enabled = false;
                swapPercentToken1.Enabled = false; swapPercentToken2.Enabled = false; swapPercentToken3.Enabled = false; swapPercentToken4.Enabled = false;
                swapBackNativeToken1.Enabled = false; swapBackNativeToken2.Enabled = false; swapBackNativeToken3.Enabled = false; swapBackNativeToken4.Enabled = false;
                swapBackNativeToken1.Checked = false; swapBackNativeToken2.Checked = false; swapBackNativeToken3.Checked = false; swapBackNativeToken4.Checked = false;
                swapTokenSlippage.Enabled = false; swapTokenLoopCount.Enabled = false;
                routerContractBoxLabel.Enabled = false; swapContract1Label.Enabled = false; swapContract2Label.Enabled = false; swapContract3Label.Enabled = false; swapContract4Label.Enabled = false;
                swapPercentToken1Label.Enabled = false; swapPercentToken2Label.Enabled = false; swapPercentToken3Label.Enabled = false; swapPercentToken4Label.Enabled = false;
                swapTokenSlippageLabel.Enabled = false; swapTokenLoopCountLabel.Enabled = false;
                enableSwapToken1.Checked = false;
                enableSwapToken2.Checked = false;
                enableSwapToken3.Checked = false;
                enableSwapToken4.Checked = false;
            }

        }


        private void loadAccountsFromPrivateKey_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < privatekeycount; i++)
            {
                Console.WriteLine("Account " + i + " : - Address : " + accountaddress[i] + " - Private key : " + accountprivatekey[i] + " - Account Balance : " + accountbalance[i]);
            }
        }

        private void enablePrivateKey1_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck1.Checked == true)
            {
                privateKeyBox1.Enabled = true;
                privateKeyCheck2.Enabled = true;
                privatekeycount = 1;
                button3.Enabled = true;

            }
            if (privateKeyCheck1.Checked == false)
            {
                privateKeyBox1.Enabled = false;
                privateKeyCheck2.Enabled = false;
                privateKeyBox2.Enabled = false;
                privateKeyCheck3.Enabled = false;
                privateKeyBox3.Enabled = false;
                privateKeyCheck4.Enabled = false;
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck2.Checked = false;
                privateKeyCheck3.Checked = false;
                privateKeyCheck4.Checked = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                button3.Enabled = false;

                privatekeycount = 0;


            }
        }

        private void enablePrivateKey2_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck2.Checked == true)
            {
                privateKeyBox2.Enabled = true;
                privateKeyCheck3.Enabled = true;
                privatekeycount = 2;

            }
            if (privateKeyCheck2.Checked == false)
            {
                privateKeyBox2.Enabled = false;
                privateKeyCheck3.Enabled = false;
                privateKeyBox3.Enabled = false;
                privateKeyCheck4.Enabled = false;
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck3.Checked = false;
                privateKeyCheck4.Checked = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 1;

            }
        }

        private void enablePrivateKey3_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck3.Checked == true)
            {
                privateKeyBox3.Enabled = true;
                privateKeyCheck4.Enabled = true;
                privatekeycount = 3;

            }
            if (privateKeyCheck3.Checked == false)
            {
                privateKeyBox3.Enabled = false;
                privateKeyCheck4.Enabled = false;
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck4.Checked = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 2;


            }
        }

        private void enablePrivateKey4_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck4.Checked == true)
            {
                privateKeyBox4.Enabled = true;
                privateKeyCheck5.Enabled = true;
                privatekeycount = 4;

            }
            if (privateKeyCheck4.Checked == false)
            {
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 3;


            }
        }

        private void enablePrivateKey5_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck5.Checked == true)
            {
                privateKeyBox5.Enabled = true;
                privateKeyCheck6.Enabled = true;
                privatekeycount = 5;

            }
            if (privateKeyCheck5.Checked == false)
            {
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 4;

            }
        }

        private void enablePrivateKey6_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck6.Checked == true)
            {
                privateKeyBox6.Enabled = true;
                privatekeycount = 6;

            }
            if (privateKeyCheck6.Checked == false)
            {
                privateKeyBox6.Enabled = false;
                privatekeycount = 5;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            rpc = rpcURL.Text;
            testRPCBackground.RunWorkerAsync();
            while (testRPCBackground.IsBusy == true)
            {
                Application.DoEvents();
            }
            button2.Enabled = true;

        }

        private void getAccountBalanceBackground_DoWork(object sender, DoWorkEventArgs e)
        {

            GetAccountData().Wait();

        }

        public static async Task GetAccountData()
        {
            await GetBalance();
        }

        static async Task GetBalance()
        {
            var web3 = new Web3(rpc);
            var balance = await web3.Eth.GetBalance.SendRequestAsync(accountname);
            //Console.WriteLine($"Balance in Wei: {balance.Value}");
            var etherAmount = Web3.Convert.FromWei(balance.Value);
            //Console.WriteLine($"Balance in Ether: {etherAmount}");
            tempbalance = etherAmount.ToString();
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }





        private void testRPCBackground_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectTestRPCAsync().Wait();

        }

        public static async Task ConnectTestRPCAsync()
        {
            await ConnectTestRPC();
        }

        static async Task ConnectTestRPC()
        {
            var web3 = new Web3(rpc);
            var latestBlockNumber = await web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
            Console.WriteLine($"Connection Established To RPC. Last Block Number is: {latestBlockNumber.Value}");


        }

        public class TokenTransferSettings
        {
            public bool TransferERC20 { get; set; }
            public bool EnableToken1 { get; set; }
            public string TokenContract1 { get; set; }
            public string Token1TransferPercent { get; set; }
            public bool TransferBackERC20ToFirstAddressToken1 { get; set; }
            public bool EnableToken2 { get; set; }
            public string TokenContract2 { get; set; }
            public string Token2TransferPercent { get; set; }
            public bool TransferBackERC20ToFirstAddressToken2 { get; set; }
            public bool EnableToken3 { get; set; }
            public string TokenContract3 { get; set; }
            public string Token3TransferPercent { get; set; }
            public bool TransferBackERC20ToFirstAddressToken3 { get; set; }
            public bool EnableToken4 { get; set; }
            public string TokenContract4 { get; set; }
            public string Token4TransferPercent { get; set; }
            public string TransferTokenLoopCount { get; set; }
            public bool TransferBackERC20ToFirstAddressToken4 { get; set; }





        }

        public class General
        {
            public string SettingsName { get; set; }
            public string RPC { get; set; }
        }

        public class NativeBalanceSettings
        {
            public bool TransferNativeBalance { get; set; }
            public string NativeTransferLoop { get; set; }
            public string NativeTransferPercent { get; set; }

        }

        public class PrivateKeyModeSettings
        {
            public bool EnablePrivateKey1 { get; set; }
            public string PrivateKeyBox1 { get; set; }
            public bool EnablePrivateKey2 { get; set; }
            public string PrivateKeyBox2 { get; set; }
            public bool EnablePrivateKey3 { get; set; }
            public string PrivateKeyBox3 { get; set; }
            public bool EnablePrivateKey4 { get; set; }
            public string PrivateKeyBox4 { get; set; }
            public bool EnablePrivateKey5 { get; set; }
            public string PrivateKeyBox5 { get; set; }
            public bool EnablePrivateKey6 { get; set; }
            public string PrivateKeyBox6 { get; set; }
        }

        public class Config
        {
            public General General { get; set; }
            public WorkingModeSettings WorkingModeSettings { get; set; }
            public PrivateKeyModeSettings PrivateKeyModeSettings { get; set; }
            public SeedModeSettings SeedModeSettings { get; set; }
        }

        public class SeedModeSettings
        {
            public string Seed { get; set; }
            public string ExtraWord { get; set; }
            public string AccountCount { get; set; }
        }

        public class TokenSwapSettings
        {
            public bool SwapToken { get; set; }
            public string RouterContract { get; set; }
            public string SlippagePercent { get; set; }
            public string SwapTokenLoopCount { get; set; }
            public bool EnableToken1 { get; set; }
            public string TokenContract1 { get; set; }
            public string Token1SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken1 { get; set; }
            public bool EnableToken2 { get; set; }
            public string TokenContract2 { get; set; }
            public string Token2SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken2 { get; set; }
            public bool EnableToken3 { get; set; }
            public string TokenContract3 { get; set; }
            public string Token3SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken3 { get; set; }
            public bool EnableToken4 { get; set; }
            public string TokenContract4 { get; set; }
            public string Token4SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken4 { get; set; }
        }

        public class WorkingModeSettings
        {
            public bool PrivateKeyMode { get; set; }
            public bool SeedMode { get; set; }
            public NativeBalanceSettings NativeBalanceSettings { get; set; }
            public TokenTransferSettings TokenTransferSettings { get; set; }
            public TokenSwapSettings TokenSwapSettings { get; set; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Config appConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@Path.GetDirectoryName(Application.ExecutablePath) + "\\" + settingsName.Text + ".json"));
            //RPC
            rpcURL.Text = appConfig.General.RPC;
            settingsName.Text = appConfig.General.SettingsName;

            if (appConfig.WorkingModeSettings.SeedMode == true && appConfig.WorkingModeSettings.PrivateKeyMode == false)
            {
                seedMode.Checked = true;
            }
            if (appConfig.WorkingModeSettings.SeedMode == false && appConfig.WorkingModeSettings.PrivateKeyMode == true)
            {
                privateKeyMode.Checked = true;
            }
            if (appConfig.WorkingModeSettings.SeedMode == true && appConfig.WorkingModeSettings.PrivateKeyMode == true)
            {
                privateKeyMode.Checked = false;
                seedMode.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "'PrivateKeyMode' And 'SeedMode' Parameters Cannot Be 'true' Both.");
            }
            if (appConfig.WorkingModeSettings.SeedMode == false && appConfig.WorkingModeSettings.PrivateKeyMode == false)
            {
                privateKeyMode.Checked = false;
                seedMode.Checked = false;
                MessageBox.Show("'PrivateKeyMode' or 'SeedMode' Parameter Must Set To 'true'.");
            }

            //TransferNativeBalanceCheck
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == false)
            {
                transferNativeBalanceCheck.Checked = true;
            }

            //SwapTokenCheck
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == true)
            {
                swapTokensCheck.Checked = true;
            }


            //TransferTokenCheck
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == true)
            {
                transferTokensCheck.Checked = true;
            }

            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == true)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferERC20' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == true)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferERC20' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == true)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferERC20' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == false)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferERC20' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == false)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferERC20' or 'SwapToken' to 'true'.");
            }



            //TokenSwapSettings
            routerContractBox.Text = appConfig.WorkingModeSettings.TokenSwapSettings.RouterContract;
            if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken1 == true)
            {
                enableSwapToken1.Checked = true;
                if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken1 == true)
                {
                    swapBackNativeToken1.Checked = true;

                }
                else
                {
                    swapBackNativeToken1.Checked = false;
                }
                if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken2 == true)
                {
                    enableSwapToken2.Checked = true;
                    if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken2 == true)
                    {
                        swapBackNativeToken2.Checked = true;

                    }
                    else
                    {
                        swapBackNativeToken2.Checked = false;
                    }
                    if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken3 == true)
                    {
                        enableSwapToken3.Checked = true;
                        if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken3 == true)
                        {
                            swapBackNativeToken3.Checked = true;


                        }
                        else
                        {
                            swapBackNativeToken3.Checked = false;
                        }

                        if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken4 == true)
                        {
                            enableSwapToken4.Checked = true;
                            if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken4 == true)
                            {
                                swapBackNativeToken4.Checked = true;
                            }
                            else
                            {
                                swapBackNativeToken4.Checked = false;
                            }
                        }
                        else
                        {
                            enableSwapToken4.Checked = false;
                        }
                    }
                    else
                    {
                        enableSwapToken3.Checked = false;
                    }
                }
                else
                {
                    enableSwapToken2.Checked = false;
                }
            }
            else
            {
                enableSwapToken1.Checked = false;
            }

            swapContract1.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract1;
            swapPercentToken1.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token1SwapPercent;
            swapContract2.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract2;
            swapPercentToken2.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token2SwapPercent;
            swapContract3.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract3;
            swapPercentToken3.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token3SwapPercent;
            swapContract4.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract4;
            swapPercentToken4.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token4SwapPercent;
            swapTokenSlippage.Text = appConfig.WorkingModeSettings.TokenSwapSettings.SlippagePercent;
            swapTokenLoopCount.Text = appConfig.WorkingModeSettings.TokenSwapSettings.SwapTokenLoopCount;


            //TokenTransferSettings
            if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken1 == true)
            {
                enableTransferToken1.Checked = true;
                if (appConfig.WorkingModeSettings.TokenTransferSettings.TransferBackERC20ToFirstAddressToken1 == true)
                {
                    transferBackToAccount1.Checked = true;

                }
                else
                {
                    transferBackToAccount1.Checked = false;
                }
                if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken2 == true)
                {
                    enableTransferToken2.Checked = true;
                    if (appConfig.WorkingModeSettings.TokenTransferSettings.TransferBackERC20ToFirstAddressToken2 == true)
                    {
                        transferBackToAccount2.Checked = true;

                    }
                    else
                    {
                        transferBackToAccount2.Checked = false;
                    }
                    if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken3 == true)
                    {
                        enableTransferToken3.Checked = true;
                        if (appConfig.WorkingModeSettings.TokenTransferSettings.TransferBackERC20ToFirstAddressToken3 == true)
                        {
                            transferBackToAccount3.Checked = true;


                        }
                        else
                        {
                            transferBackToAccount3.Checked = false;
                        }

                        if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken4 == true)
                        {
                            enableTransferToken4.Checked = true;
                            if (appConfig.WorkingModeSettings.TokenTransferSettings.TransferBackERC20ToFirstAddressToken4 == true)
                            {
                                transferBackToAccount4.Checked = true;
                            }
                            else
                            {
                                transferBackToAccount4.Checked = false;
                            }
                        }
                        else
                        {
                            enableTransferToken4.Checked = false;
                        }
                    }
                    else
                    {
                        enableTransferToken3.Checked = false;
                    }
                }
                else
                {
                    enableTransferToken2.Checked = false;
                }
            }
            else
            {
                enableTransferToken1.Checked = false;
            }

            transferContract1.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract1;
            transferPercentToken1.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token1TransferPercent;
            transferContract2.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract2;
            transferPercentToken2.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token2TransferPercent;
            transferContract3.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract3;
            transferPercentToken3.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token3TransferPercent;
            transferContract4.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract4;
            transferPercentToken4.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token4TransferPercent;
            transferTokenLoopCount.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TransferTokenLoopCount;
            //NativeBalanceTransferSettings
            nativeTransferLoop.Text = appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferLoop;
            nativeTransferPercent.Text = appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferPercent;

            //SeedSettings
            seedPhrase.Text = appConfig.SeedModeSettings.Seed;
            extraWord.Text = appConfig.SeedModeSettings.ExtraWord;
            accountCount.Text = appConfig.SeedModeSettings.AccountCount;

            //PrivateKeySetup
            if (appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 == true)
            {
                transferTokensCheck.Checked = true;
            }
            else
            {
                transferTokensCheck.Checked = false;
            }
            MessageBox.Show(





                "General" + "\n" +
                "Settings Name: " + appConfig.General.SettingsName + "\n" +
                "RPC: " + appConfig.General.RPC + "\n" +
                "Working Mode Settings" + "\n" +
                "Working Mode: " + appConfig.WorkingModeSettings.PrivateKeyMode + "\n" +
                "Working Mode: " + appConfig.WorkingModeSettings.SeedMode + "\n" +

                "Native Transfer Loop: " + appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferLoop + "\n" +
                "Transfer Native Balance? " + appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance + "\n" +
                "ERC20Settings" + "\n" +
                "TransferToken?: " + appConfig.WorkingModeSettings.TokenTransferSettings.TransferERC20 + "\n" +
                "TransferToken Loop: " + appConfig.WorkingModeSettings.TokenTransferSettings.TransferTokenLoopCount + "\n" +
                "Enable Token 1?: " + appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract1 + "\n" +

                "Transfer Token Contract 1: " + appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract1 + "\n" +
                "Transfer Token Contract 1 Transfer Percent: " + appConfig.WorkingModeSettings.TokenTransferSettings.Token1TransferPercent + "\n" +
                "Transfer Token Contract 2: " + appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract2 + "\n" +
                "Transfer Token Contract 2 Transfer Percent: " + appConfig.WorkingModeSettings.TokenTransferSettings.Token2TransferPercent + "\n" +
                "Transfer Token Contract 3: " + appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract3 + "\n" +
                "Transfer Token Contract 3 Transfer Percent: " + appConfig.WorkingModeSettings.TokenTransferSettings.Token3TransferPercent + "\n" +
                "Transfer Token Contract 4: " + appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract4 + "\n" +
                "Transfer Token Contract 4 Transfer Percent: " + appConfig.WorkingModeSettings.TokenTransferSettings.Token4TransferPercent + "\n" +
                "TokenSwapSettings" + "\n" +
                "RouterContract: " + appConfig.WorkingModeSettings.TokenSwapSettings.RouterContract + "\n" +
                "SwapToken: " + appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken + "\n" +
                "SlippagePercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.SlippagePercent + "\n" +
                "SwapToken?: " + appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken + "\n" +
                "TokenContract1: " + appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract1 + "\n" +
                "Token1SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.Token1SwapPercent + "\n" +
                "Token1SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken1 + "\n" +
                "TokenContract2: " + appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract2 + "\n" +
                "Token2SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.Token2SwapPercent + "\n" +
                "Token2SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken2 + "\n" +
                "TokenContract3: " + appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract3 + "\n" +
                "Token3SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.Token3SwapPercent + "\n" +
                "Token3SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken3 + "\n" +
                "TokenContract4: " + appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract4 + "\n" +
                "Token4SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.Token4SwapPercent + "\n" +
                "Token4SwapPercent: " + appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken4 + "\n" +

                "Privatekey Mode Settings" + "\n" +
                "EnablePrivateKey1: " + appConfig.PrivateKeyModeSettings.EnablePrivateKey1 + "\n" +
                "PrivateKeyBox1: " + appConfig.PrivateKeyModeSettings.PrivateKeyBox1 + "\n" +
                "EnablePrivateKey2: " + appConfig.PrivateKeyModeSettings.EnablePrivateKey2 + "\n" +
                "PrivateKeyBox2: " + appConfig.PrivateKeyModeSettings.PrivateKeyBox2 + "\n" +
                "EnablePrivateKey3: " + appConfig.PrivateKeyModeSettings.EnablePrivateKey3 + "\n" +
                "PrivateKeyBox3: " + appConfig.PrivateKeyModeSettings.PrivateKeyBox3 + "\n" +
                "EnablePrivateKey4: " + appConfig.PrivateKeyModeSettings.EnablePrivateKey4 + "\n" +
                "PrivateKeyBox4: " + appConfig.PrivateKeyModeSettings.PrivateKeyBox4 + "\n" +
                "EnablePrivateKey5: " + appConfig.PrivateKeyModeSettings.EnablePrivateKey5 + "\n" +
                "PrivateKeyBox5: " + appConfig.PrivateKeyModeSettings.PrivateKeyBox5 + "\n" +
                "EnablePrivateKey6: " + appConfig.PrivateKeyModeSettings.EnablePrivateKey6 + "\n" +
                "PrivateKeyBox6: " + appConfig.PrivateKeyModeSettings.PrivateKeyBox6 + "\n" +

                "SeedmodeSettings" + "\n" +
                "Seed: " + appConfig.SeedModeSettings.Seed + "\n" +
                "ExtraWord: " + appConfig.SeedModeSettings.ExtraWord + "\n" +
                "AccountRotationCount: " + appConfig.SeedModeSettings.AccountCount
                );



        }



        private void enableSwapToken1_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken1.Checked == true)
            {
                swapContract1.Enabled = true;
                swapContract1Label.Enabled = true;
                swapPercentToken1.Enabled = true;
                swapBackNativeToken1.Enabled = true;
                swapPercentToken1Label.Enabled = true;
                enableSwapToken2.Enabled = true;

            }
            if (enableSwapToken1.Checked == false)
            {
                swapContract1.Enabled = false;
                swapContract1Label.Enabled = false;
                swapPercentToken1.Enabled = false;
                swapBackNativeToken1.Enabled = false;
                swapBackNativeToken1.Checked = false;
                swapPercentToken1Label.Enabled = false;
                swapContract2.Enabled = false;
                swapContract2Label.Enabled = false;
                swapPercentToken2.Enabled = false;
                swapBackNativeToken2.Enabled = false;
                swapBackNativeToken2.Checked = false;
                swapPercentToken2Label.Enabled = false;
                swapContract3.Enabled = false;
                swapContract3Label.Enabled = false;
                swapPercentToken3.Enabled = false;
                swapBackNativeToken3.Enabled = false;
                swapBackNativeToken3.Checked = false;
                swapPercentToken3Label.Enabled = false;
                enableSwapToken4.Enabled = false;
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
                enableSwapToken2.Enabled = false;
                enableSwapToken3.Enabled = false;
                enableSwapToken4.Enabled = false;
                enableSwapToken2.Checked = false;
                enableSwapToken3.Checked = false;
                enableSwapToken4.Checked = false;
            }
        }

        private void enableSwapToken2_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken2.Checked == true)
            {
                swapContract2.Enabled = true;
                swapContract2Label.Enabled = true;
                swapPercentToken2.Enabled = true;
                swapBackNativeToken2.Enabled = true;
                swapPercentToken2Label.Enabled = true;
                enableSwapToken3.Enabled = true;

            }
            if (enableSwapToken2.Checked == false)
            {
                swapContract2.Enabled = false;
                swapContract2Label.Enabled = false;
                swapPercentToken2.Enabled = false;
                swapBackNativeToken2.Enabled = false;
                swapBackNativeToken2.Checked = false;
                swapPercentToken2Label.Enabled = false;
                swapContract3.Enabled = false;
                swapContract3Label.Enabled = false;
                swapPercentToken3.Enabled = false;
                swapBackNativeToken3.Enabled = false;
                swapBackNativeToken3.Checked = false;
                swapPercentToken3Label.Enabled = false;
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
                enableSwapToken3.Enabled = false;
                enableSwapToken4.Enabled = false;
                enableSwapToken3.Checked = false;
                enableSwapToken4.Checked = false;

            }
        }

        private void enableSwapToken3_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken3.Checked == true)
            {
                swapContract3.Enabled = true;
                swapContract3Label.Enabled = true;
                swapPercentToken3.Enabled = true;
                swapBackNativeToken3.Enabled = true;
                swapPercentToken3Label.Enabled = true;
                enableSwapToken4.Enabled = true;

            }
            if (enableSwapToken3.Checked == false)
            {
                swapContract3.Enabled = false;
                swapContract3Label.Enabled = false;
                swapPercentToken3.Enabled = false;
                swapBackNativeToken3.Enabled = false;
                swapBackNativeToken3.Checked = false;
                swapPercentToken3Label.Enabled = false;
                enableSwapToken4.Enabled = false;
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
                enableSwapToken4.Enabled = false;
                enableSwapToken4.Checked = false;
            }
        }

        private void enableSwapToken4_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken4.Checked == true)
            {
                swapContract4.Enabled = true;
                swapContract4Label.Enabled = true;
                swapPercentToken4.Enabled = true;
                swapBackNativeToken4.Enabled = true;
                swapPercentToken4Label.Enabled = true;
            }
            if (enableSwapToken4.Checked == false)
            {
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
            }
        }



        private void enableTransferToken1_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken1.Checked == true)
            {
                transferContract1.Enabled = true;
                transferContract1Label.Enabled = true;
                transferPercentToken1.Enabled = true;
                transferBackToAccount1.Enabled = true;
                transferPercentToken1Label.Enabled = true;
                enableTransferToken2.Enabled = true;

            }
            if (enableTransferToken1.Checked == false)
            {
                transferContract1.Enabled = false;
                transferContract1Label.Enabled = false;
                transferPercentToken1.Enabled = false;
                transferBackToAccount1.Enabled = false;
                transferBackToAccount1.Checked = false;
                transferPercentToken1Label.Enabled = false;
                transferContract2.Enabled = false;
                transferContract2Label.Enabled = false;
                transferPercentToken2.Enabled = false;
                transferBackToAccount2.Enabled = false;
                transferBackToAccount2.Checked = false;
                transferPercentToken2Label.Enabled = false;
                transferContract3.Enabled = false;
                transferContract3Label.Enabled = false;
                transferPercentToken3.Enabled = false;
                transferBackToAccount3.Enabled = false;
                transferBackToAccount3.Checked = false;
                transferPercentToken3Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;
                transferBackToAccount4.Enabled = false;
                transferBackToAccount4.Checked = false;
                transferPercentToken4Label.Enabled = false;
                enableTransferToken2.Enabled = false;
                enableTransferToken3.Enabled = false;
                enableTransferToken4.Enabled = false;
                enableTransferToken2.Checked = false;
                enableTransferToken3.Checked = false;
                enableTransferToken4.Checked = false;
            }
        }

        private void enableTransferToken2_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken2.Checked == true)
            {
                transferContract2.Enabled = true;
                transferContract2Label.Enabled = true;
                transferPercentToken2.Enabled = true;
                transferBackToAccount2.Enabled = true;
                transferPercentToken2Label.Enabled = true;
                enableTransferToken3.Enabled = true;

            }
            if (enableTransferToken2.Checked == false)
            {
                transferContract2.Enabled = false;
                transferContract2Label.Enabled = false;
                transferPercentToken2.Enabled = false;
                transferBackToAccount2.Enabled = false;
                transferBackToAccount2.Checked = false;
                transferPercentToken2Label.Enabled = false;
                transferContract3.Enabled = false;
                transferContract3Label.Enabled = false;
                transferPercentToken3.Enabled = false;
                transferBackToAccount3.Enabled = false;
                transferBackToAccount3.Checked = false;
                transferPercentToken3Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;
                transferBackToAccount4.Enabled = false;
                transferBackToAccount4.Checked = false;
                transferPercentToken4Label.Enabled = false;
                enableTransferToken3.Enabled = false;
                enableTransferToken4.Enabled = false;
                enableTransferToken3.Checked = false;
                enableTransferToken4.Checked = false;
            }
        }

        private void enableTransferToken3_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken3.Checked == true)
            {
                transferContract3.Enabled = true;
                transferContract3Label.Enabled = true;
                transferPercentToken3.Enabled = true;
                transferBackToAccount3.Enabled = true;
                transferPercentToken3Label.Enabled = true;
                enableTransferToken4.Enabled = true;

            }
            if (enableTransferToken3.Checked == false)
            {
                transferContract3.Enabled = false;
                transferContract3Label.Enabled = false;
                transferPercentToken3.Enabled = false;
                transferBackToAccount3.Enabled = false;
                transferBackToAccount3.Checked = false;
                transferPercentToken3Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;
                transferBackToAccount4.Enabled = false;
                transferBackToAccount4.Checked = false;
                transferPercentToken4Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                enableTransferToken4.Checked = false;
            }
        }

        private void enableTransferToken4_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken4.Checked == true)
            {
                transferContract4.Enabled = true;
                transferContract4Label.Enabled = true;
                transferPercentToken4.Enabled = true;
                transferBackToAccount4.Enabled = true;
                transferPercentToken4Label.Enabled = true;

            }
            if (enableTransferToken4.Checked == false)
            {
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;
                transferBackToAccount4.Enabled = false;
                transferPercentToken4Label.Enabled = false;
                transferBackToAccount4.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Text = "Stop";

            if (nativeBalanceTransferEngine.IsBusy == true)
            {
                Console.WriteLine("Engine will shutdown at the finish of loop...");
                button1.Enabled = false;
                button1.Text = "Stopping";

            }

            if (nativeBalanceTransferEngine.IsBusy == false)
            {
                Console.Clear();
                Console.WriteLine("Airdrop Hunter Bot Started");


                if (seedMode.Checked == true) { Console.WriteLine("Seed Mode Selected"); Console.WriteLine("You Can Work With As Wanted As Accounts"); Console.WriteLine("Seed Mode Loaded With " + privatekeycount + " Accounts."); }
                if (privateKeyMode.Checked == true) { Console.WriteLine("Private Key Mode Selected"); Console.WriteLine("You Can Work Up To 6 Accounts"); Console.WriteLine("Private Key Mode Loaded With " + privatekeycount + " Accounts."); }


                for (int i = 0; i < privatekeycount; i++)
                {
                    Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                }

                if (transferNativeBalanceCheck.Checked == true)
                {
                    Console.WriteLine("Transfer Native Balance Mode Selected"); Console.WriteLine("Bot Will Transfer Native Balance (ETH, BNB, Matic, AVAX etc.) For Loaded Accounts In Order. At Least 2 Accounts Needed. This Process Will Take As Long As The Number Of Loop Count.");
                    transferNativeBalancePercent = Convert.ToInt32(nativeTransferPercent.Text);
                    transferNativeBalanceLoop = Convert.ToInt32(nativeTransferLoop.Text);
                    nativeBalanceTransferEngine.RunWorkerAsync();
                }
                if (swapTokensCheck.Checked == true) { Console.WriteLine("Swap Tokens Mode Selected"); Console.WriteLine("Bot Will Swap Tokens. You Can Define Token Contracts Up To 4. Set Router Contract, Percent And Slippage Correctly. Router Contract Differs For Every Network. This Process Will Take As Long As The Number Of Loop Count."); }
                if (transferTokensCheck.Checked == true) { Console.WriteLine("Transfer Tokens Mode Selected"); Console.WriteLine("Bot Will Transfer Token Balances For Loaded Accounts In Order. At Least 2 Accounts Needed. You Can Define Token Contracts Up To 4. Set Percent Correctly. This Process Will Take As Long As The Number Of Loop Count."); }
            }

        }

        static private string TransferEther(Web3 web3, Account account, string toAddress, decimal amount)
        {
            var TransactionHash = "";
            try
            {
                var res = web3.Eth.GetEtherTransferService()
                                .TransferEtherAndWaitForReceiptAsync(toAddress, amount);
                //Console.WriteLine(toAddress + "amount: " + amount);

                res.Wait();
                var transaction = res.Result;
                TransactionHash = transaction.TransactionHash;
                Console.WriteLine("transaction : {0}", transaction.TransactionHash);
            }
            catch (Exception error)
            {
                Console.WriteLine("error : {0}", error);
            }
            return TransactionHash;
        }

        public static void GetTransactionReceipt(Web3 web3, string transactionHash)
        {

            try
            {
                var GetTransactionReceipt = web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                GetTransactionReceipt.Wait();
                var receipt = GetTransactionReceipt.Result;
                Console.WriteLine("BlockHash : {0}", receipt.BlockHash);
                Console.WriteLine("BlockNumber : {0}", receipt.BlockNumber.Value.ToString());
                //Console.WriteLine("GasUsed : {0}", receipt.GasUsed.Value.ToString());
                //Console.WriteLine("ContractAddress : {0}", receipt.ContractAddress);
                if (receipt.Status.Value == 1)
                {
                    Console.WriteLine("Status : Balance Transferred Successfully.");
                }
                else
                {
                    Console.WriteLine("Status : {0}", receipt.Status.Value.ToString());

                }
                //Console.WriteLine("Logs : {0}", receipt.Logs);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Get contract address failed : {0}", exp.Message);
            }
        }

        static private async Task CheckBalance(Web3 web3, string address)
        {
            var balance = await web3.Eth.GetBalance.SendRequestAsync(address);
            var etherAmount = Web3.Convert.FromWei(balance.Value);
            Console.WriteLine(address + ": " + etherAmount + " Ether");

        }

        private void nativeBalanceTransferEngine_DoWork(object sender, DoWorkEventArgs e)
        {
            Config appConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@Path.GetDirectoryName(Application.ExecutablePath) + "\\" + settingsName.Text + ".json"));
            for (int loop = 0; loop < Convert.ToInt32(appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferLoop); loop++)
            {
                if (button1.Text == "Stopping")
                {
                    button1.Text = "Start";
                    button1.Enabled = true;
                    break;

                }
                for (int i = 0; i < privatekeycount; i++)
                {
                    if (button1.Text == "Stopping")
                    {
                        button1.Text = "Start";
                        button1.Enabled = true;
                        break;
                    }
                    //Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                    var account = new Account(accountprivatekey[i]);
                    rpc = rpcURL.Text;
                    var web3 = new Web3(account, rpc);


                    if (i + 1 == privatekeycount)
                    {
                        // Check balance
                        //CheckBalance(web3, accountaddress[0]).Wait();
                        // Transfer ether from account to 0xa2271e783f3D469e94C4bFc099E8d7913cD99612
                        Console.WriteLine("\n" + "Balance Transfering Account " + i + " to Account 0");
                        var TransactionHash = TransferEther(web3, account, accountaddress[0], Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100);
                        // check the status of transaction
                        GetTransactionReceipt(web3, TransactionHash);
                        accountbalance[0] = (Convert.ToDecimal(accountbalance[0]) + Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        accountbalance[i] = (Convert.ToDecimal(accountbalance[i]) - Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        for (int b = 0; b < accountaddress.Length; b++)
                        {
                            if (accountaddress[b] == null)
                            {
                                break;
                            }
                            Console.WriteLine("Account " + (b) + " Balance: " + accountbalance[b]);

                        }
                        // Check balance
                        //CheckBalance(web3, accountaddress[i + 1]).Wait();
                    }
                    else
                    {
                        // Check balance
                        //CheckBalance(web3, accountaddress[i + 1]).Wait();
                        // Transfer ether from account to 0xa2271e783f3D469e94C4bFc099E8d7913cD99612
                        Console.WriteLine("\n" + "Balance Transfering Account " + i + " to Account " + (i + 1));
                        var TransactionHash = TransferEther(web3, account, accountaddress[i + 1], Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100);
                        // check the status of transaction
                        GetTransactionReceipt(web3, TransactionHash);
                        // Check balance
                        //CheckBalance(web3, accountaddress[i + 1]).Wait();
                        accountbalance[i + 1] = (Convert.ToDecimal(accountbalance[i + 1]) + Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        accountbalance[i] = (Convert.ToDecimal(accountbalance[i]) - Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        for (int b = 0; b < accountaddress.Length; b++)
                        {
                            if (accountaddress[b] == null)
                            {
                                break;
                            }
                            Console.WriteLine("Account " + (b) + " Balance: " + accountbalance[b]);

                        }
                    }


                }
            }
            button1.Text = "Start";

        }
    }
}
