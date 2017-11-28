using Neo.Properties;
using Neo.SmartContract;
using Neo.VM;
using Neo.Wallets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo.UI
{
    public partial class QueryDialog : Form
    {
        private UInt160 scriptHash;
        private AssetDescriptor asset;

        public QueryDialog()
        {
            InitializeComponent();
            string[] arrScriptHash = Settings.Default.NEP5Watched.OfType<string>().ToArray();
            foreach (string item in arrScriptHash)
            {
                comboBox1.Items.Add(item);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.scriptHash = UInt160.Parse(comboBox1.SelectedItem as string);
            this.asset = new AssetDescriptor(this.scriptHash);
        }

        private void Query_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show(Strings.ChooseScriptHash);
                return;
            }
            byte[] script;
            using (ScriptBuilder sb = new ScriptBuilder())
            {
                sb.EmitAppCall(scriptHash, "totalSupply");
                sb.EmitAppCall(scriptHash, "totalToken");
                sb.EmitAppCall(scriptHash, "icoToken");
                sb.EmitAppCall(scriptHash, "icoNeo");
                sb.EmitAppCall(scriptHash, "symbol");
                script = sb.ToArray();
            }
            ApplicationEngine engine = ApplicationEngine.Run(script);
            if (!engine.State.HasFlag(VMState.FAULT))
            {
                this.txtbx_name.Text = asset.AssetName;
                this.txtbx_precision.Text = asset.Decimals.ToString();

                //symbol
                this.txtbx_symbol.Text = engine.EvaluationStack.Pop().GetString();

                //icoNeo
                BigInteger _icoNeo = engine.EvaluationStack.Pop().GetBigInteger();
                BigDecimal icoNeo = new BigDecimal(_icoNeo, asset.Decimals);
                this.txtbx_icoNeo.Text = icoNeo.ToString();

                //icoToken
                BigInteger _icoToken = engine.EvaluationStack.Pop().GetBigInteger();
                BigDecimal icoToken = new BigDecimal(_icoToken, asset.Decimals);
                this.txtbx_icoToken.Text = icoToken.ToString();

                //totalToken
                BigInteger _totalToken = engine.EvaluationStack.Pop().GetBigInteger();
                BigDecimal totalToken = new BigDecimal(_totalToken, asset.Decimals);
                this.txtbx_totalToken.Text = totalToken.ToString();

                //totalSupply
                BigInteger _totalSupply = engine.EvaluationStack.Pop().GetBigInteger();
                BigDecimal totalSupply = new BigDecimal(_totalSupply, asset.Decimals);
                this.txtbx_totalSupply.Text = totalSupply.ToString();
            }
            else
            {
                MessageBox.Show("Query Failed");
            }
        }

        public static DateTime ConvertIntDateTime(double d)
        {
            DateTime time = System.DateTime.MinValue;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            return time;
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show(Strings.ChooseScriptHash);
                return;
            }
            UInt160 address = Wallet.ToScriptHash(txtbx_address.Text);
            byte[] script;
            using (ScriptBuilder sb = new ScriptBuilder())
            {
                sb.EmitAppCall(scriptHash, "balanceOf", address);
                script = sb.ToArray();
            }
            ApplicationEngine engine = ApplicationEngine.Run(script);
            if (!engine.State.HasFlag(VMState.FAULT))
            {
                BigInteger _balance = engine.EvaluationStack.Pop().GetBigInteger();
                BigDecimal balance = new BigDecimal(_balance, asset.Decimals);
                this.txtbx_balance.Text = balance.ToString()+ " " + asset.AssetName;
            }
            else
            {
                MessageBox.Show("Query Failed");
            }
        }
    }
}
