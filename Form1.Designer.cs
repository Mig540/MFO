namespace MFO
{
    partial class Form1
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
            this.button_AcOps = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_BKI = new System.Windows.Forms.Button();
            this.button_Contract = new System.Windows.Forms.Button();
            this.button_History = new System.Windows.Forms.Button();
            this.button_Entity = new System.Windows.Forms.Button();
            this.button_Accounts = new System.Windows.Forms.Button();
            this.button_MFO = new System.Windows.Forms.Button();
            this.button_zeroBalance = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AcOps
            // 
            this.button_AcOps.Location = new System.Drawing.Point(32, 351);
            this.button_AcOps.Name = "button_AcOps";
            this.button_AcOps.Size = new System.Drawing.Size(101, 43);
            this.button_AcOps.TabIndex = 0;
            this.button_AcOps.Text = "Операции со счетами";
            this.button_AcOps.UseVisualStyleBackColor = true;
            this.button_AcOps.Click += new System.EventHandler(this.button_AcOps_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(567, 267);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_BKI
            // 
            this.button_BKI.Location = new System.Drawing.Point(139, 351);
            this.button_BKI.Name = "button_BKI";
            this.button_BKI.Size = new System.Drawing.Size(101, 43);
            this.button_BKI.TabIndex = 2;
            this.button_BKI.Text = "Бюро кредитных историй";
            this.button_BKI.UseVisualStyleBackColor = true;
            this.button_BKI.Click += new System.EventHandler(this.button_BKI_Click);
            // 
            // button_Contract
            // 
            this.button_Contract.Location = new System.Drawing.Point(246, 351);
            this.button_Contract.Name = "button_Contract";
            this.button_Contract.Size = new System.Drawing.Size(101, 43);
            this.button_Contract.TabIndex = 3;
            this.button_Contract.Text = "Кредитные контракты";
            this.button_Contract.UseVisualStyleBackColor = true;
            this.button_Contract.Click += new System.EventHandler(this.button_Contract_Click);
            // 
            // button_History
            // 
            this.button_History.Location = new System.Drawing.Point(353, 351);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(101, 43);
            this.button_History.TabIndex = 4;
            this.button_History.Text = "Кредитные истории";
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            // 
            // button_Entity
            // 
            this.button_Entity.Location = new System.Drawing.Point(32, 400);
            this.button_Entity.Name = "button_Entity";
            this.button_Entity.Size = new System.Drawing.Size(101, 43);
            this.button_Entity.TabIndex = 5;
            this.button_Entity.Text = "Юридические лица";
            this.button_Entity.UseVisualStyleBackColor = true;
            this.button_Entity.Click += new System.EventHandler(this.button_Entity_Click);
            // 
            // button_Accounts
            // 
            this.button_Accounts.Location = new System.Drawing.Point(139, 400);
            this.button_Accounts.Name = "button_Accounts";
            this.button_Accounts.Size = new System.Drawing.Size(101, 43);
            this.button_Accounts.TabIndex = 6;
            this.button_Accounts.Text = "Баланс на счетах";
            this.button_Accounts.UseVisualStyleBackColor = true;
            this.button_Accounts.Click += new System.EventHandler(this.button_Accounts_Click);
            // 
            // button_MFO
            // 
            this.button_MFO.Location = new System.Drawing.Point(246, 400);
            this.button_MFO.Name = "button_MFO";
            this.button_MFO.Size = new System.Drawing.Size(101, 43);
            this.button_MFO.TabIndex = 7;
            this.button_MFO.Text = "МФО";
            this.button_MFO.UseVisualStyleBackColor = true;
            this.button_MFO.Click += new System.EventHandler(this.button_MFO_Click);
            // 
            // button_zeroBalance
            // 
            this.button_zeroBalance.Location = new System.Drawing.Point(605, 51);
            this.button_zeroBalance.Name = "button_zeroBalance";
            this.button_zeroBalance.Size = new System.Drawing.Size(101, 43);
            this.button_zeroBalance.TabIndex = 8;
            this.button_zeroBalance.Text = "Лица с нуевым балансом";
            this.button_zeroBalance.UseVisualStyleBackColor = true;
            this.button_zeroBalance.Click += new System.EventHandler(this.button_zeroBalance_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(605, 244);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(101, 43);
            this.button_insert.TabIndex = 9;
            this.button_insert.Text = "Вставить";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_zeroBalance);
            this.Controls.Add(this.button_MFO);
            this.Controls.Add(this.button_Accounts);
            this.Controls.Add(this.button_Entity);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.button_Contract);
            this.Controls.Add(this.button_BKI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_AcOps);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AcOps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_BKI;
        private System.Windows.Forms.Button button_Contract;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_Entity;
        private System.Windows.Forms.Button button_Accounts;
        private System.Windows.Forms.Button button_MFO;
        private System.Windows.Forms.Button button_zeroBalance;
        private System.Windows.Forms.Button button_insert;
    }
}

