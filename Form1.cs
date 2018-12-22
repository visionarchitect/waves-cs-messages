using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WavesCS;

namespace WavesPoC1
{
    public partial class Form1 : Form
    {
        public PrivateKeyAccount mySeed;
        Node node = new Node();
        DateTime lastMsg = DateTime.MaxValue;
        public Form1()
        {
            InitializeComponent();
        }
        //3N3Mh4bBMuPusdpnvGJpShDug3uosxB8SLE
        private void btnSync_Click(object sender, EventArgs e)
        {
            try
            {
                mySeed = PrivateKeyAccount.CreateFromSeed(tbSeed.Text.Trim(), AddressEncoding.TestNet);
                tbAddress.Text = mySeed.Address;
                lbValue.Text = node.GetBalance(mySeed.Address).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                node.Transfer(mySeed, tbRecipiant.Text, Assets.WAVES, (decimal)0.001, tbMyMsg.Text);
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", ex.Message);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction[] trans = node.GetTransactions(tbAddress.Text, 1);
                if (trans != null && trans.Count() > 0 && lastMsg != trans[0].Timestamp)
                {
                    lastMsg = trans[0].Timestamp;
                    if (trans[0] is DataTransaction)
                    {
                        tbReceived.Text = tbReceived.Text + "\n\r" + ((DataTransaction)trans[0]).Entries["Data"].ToString();
                        MessageBox.Show("OK");
                        return;
                    }
                    else if (trans[0] is TransferTransaction)
                    {
                        if (((TransferTransaction)trans[0]).Recipient == tbAddress.Text.Trim())
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine(tbReceived.Text);
                            sb.AppendLine(System.Text.Encoding.Default.GetString(((TransferTransaction)trans[0]).Attachment));
                            tbReceived.Text = sb.ToString();
                            return;
                        }
                    }
                    MessageBox.Show("BAD TRANSACTION");
                    return;
                }
                MessageBox.Show("NO NEW TRANSACTIONS");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
