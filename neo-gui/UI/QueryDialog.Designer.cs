﻿namespace Neo.UI
{
    partial class QueryDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_icoNeo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_precision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_symbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_totalSupply = new System.Windows.Forms.TextBox();
            this.txtbx_inflationRate = new System.Windows.Forms.TextBox();
            this.txtbx_inflationToken = new System.Windows.Forms.TextBox();
            this.txtbx_totalToken = new System.Windows.Forms.TextBox();
            this.txtbx_infStartTime = new System.Windows.Forms.TextBox();
            this.Query = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbx_balance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbx_inflationTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbx_inflationTime);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtbx_icoNeo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtbx_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbx_precision);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbx_symbol);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbx_totalSupply);
            this.groupBox2.Controls.Add(this.txtbx_inflationRate);
            this.groupBox2.Controls.Add(this.txtbx_inflationToken);
            this.groupBox2.Controls.Add(this.txtbx_totalToken);
            this.groupBox2.Controls.Add(this.txtbx_infStartTime);
            this.groupBox2.Controls.Add(this.Query);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtbx_icoNeo
            // 
            resources.ApplyResources(this.txtbx_icoNeo, "txtbx_icoNeo");
            this.txtbx_icoNeo.Name = "txtbx_icoNeo";
            this.txtbx_icoNeo.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtbx_name
            // 
            resources.ApplyResources(this.txtbx_name, "txtbx_name");
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtbx_precision
            // 
            resources.ApplyResources(this.txtbx_precision, "txtbx_precision");
            this.txtbx_precision.Name = "txtbx_precision";
            this.txtbx_precision.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtbx_symbol
            // 
            resources.ApplyResources(this.txtbx_symbol, "txtbx_symbol");
            this.txtbx_symbol.Name = "txtbx_symbol";
            this.txtbx_symbol.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtbx_totalSupply
            // 
            resources.ApplyResources(this.txtbx_totalSupply, "txtbx_totalSupply");
            this.txtbx_totalSupply.Name = "txtbx_totalSupply";
            this.txtbx_totalSupply.ReadOnly = true;
            // 
            // txtbx_inflationRate
            // 
            resources.ApplyResources(this.txtbx_inflationRate, "txtbx_inflationRate");
            this.txtbx_inflationRate.Name = "txtbx_inflationRate";
            this.txtbx_inflationRate.ReadOnly = true;
            // 
            // txtbx_inflationToken
            // 
            resources.ApplyResources(this.txtbx_inflationToken, "txtbx_inflationToken");
            this.txtbx_inflationToken.Name = "txtbx_inflationToken";
            this.txtbx_inflationToken.ReadOnly = true;
            // 
            // txtbx_totalToken
            // 
            resources.ApplyResources(this.txtbx_totalToken, "txtbx_totalToken");
            this.txtbx_totalToken.Name = "txtbx_totalToken";
            this.txtbx_totalToken.ReadOnly = true;
            // 
            // txtbx_infStartTime
            // 
            resources.ApplyResources(this.txtbx_infStartTime, "txtbx_infStartTime");
            this.txtbx_infStartTime.Name = "txtbx_infStartTime";
            this.txtbx_infStartTime.ReadOnly = true;
            // 
            // Query
            // 
            resources.ApplyResources(this.Query, "Query");
            this.Query.Name = "Query";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbx_balance);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtbx_address);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CheckBalance);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtbx_balance
            // 
            resources.ApplyResources(this.txtbx_balance, "txtbx_balance");
            this.txtbx_balance.Name = "txtbx_balance";
            this.txtbx_balance.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtbx_address
            // 
            resources.ApplyResources(this.txtbx_address, "txtbx_address");
            this.txtbx_address.Name = "txtbx_address";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // CheckBalance
            // 
            resources.ApplyResources(this.CheckBalance, "CheckBalance");
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtbx_inflationTime
            // 
            resources.ApplyResources(this.txtbx_inflationTime, "txtbx_inflationTime");
            this.txtbx_inflationTime.Name = "txtbx_inflationTime";
            this.txtbx_inflationTime.ReadOnly = true;
            // 
            // QueryDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QueryDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_totalSupply;
        private System.Windows.Forms.TextBox txtbx_inflationRate;
        private System.Windows.Forms.TextBox txtbx_inflationToken;
        private System.Windows.Forms.TextBox txtbx_totalToken;
        private System.Windows.Forms.TextBox txtbx_infStartTime;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbx_precision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_symbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbx_balance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.TextBox txtbx_icoNeo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbx_inflationTime;
        private System.Windows.Forms.Label label13;
    }
}