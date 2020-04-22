namespace A.M.GoingUnderAndSons_Pty_Ltd
{
    partial class AMGoingUnderAndSonsLTD
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpBoxPizza = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmboQuantP1 = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmboItem = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.grpBoxPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(325, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(692, 337);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // grpBoxPizza
            // 
            this.grpBoxPizza.Controls.Add(this.btnAdd);
            this.grpBoxPizza.Controls.Add(this.cmboQuantP1);
            this.grpBoxPizza.Controls.Add(this.lblQuantity);
            this.grpBoxPizza.Controls.Add(this.cmboItem);
            this.grpBoxPizza.Controls.Add(this.lblItemType);
            this.grpBoxPizza.Location = new System.Drawing.Point(36, 62);
            this.grpBoxPizza.Name = "grpBoxPizza";
            this.grpBoxPizza.Size = new System.Drawing.Size(226, 154);
            this.grpBoxPizza.TabIndex = 11;
            this.grpBoxPizza.TabStop = false;
            this.grpBoxPizza.Text = "Item Selection";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmboQuantP1
            // 
            this.cmboQuantP1.FormattingEnabled = true;
            this.cmboQuantP1.Location = new System.Drawing.Point(85, 67);
            this.cmboQuantP1.Name = "cmboQuantP1";
            this.cmboQuantP1.Size = new System.Drawing.Size(121, 21);
            this.cmboQuantP1.TabIndex = 8;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(18, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmboItem
            // 
            this.cmboItem.FormattingEnabled = true;
            this.cmboItem.Location = new System.Drawing.Point(85, 28);
            this.cmboItem.Name = "cmboItem";
            this.cmboItem.Size = new System.Drawing.Size(121, 21);
            this.cmboItem.TabIndex = 6;
            this.cmboItem.SelectedIndexChanged += new System.EventHandler(this.cmboItem_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(18, 34);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(37, 15);
            this.lblItemType.TabIndex = 1;
            this.lblItemType.Text = "Item: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(325, 405);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(246, 39);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(686, 402);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(331, 44);
            this.btnClearList.TabIndex = 15;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click_1);
            // 
            // AMGoingUnderAndSonsLTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 456);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpBoxPizza);
            this.Name = "AMGoingUnderAndSonsLTD";
            this.Text = "A.M Going Under And Sons LTD";
            this.Load += new System.EventHandler(this.AMGoingUnderAndSonsLTD_Load);
            this.grpBoxPizza.ResumeLayout(false);
            this.grpBoxPizza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grpBoxPizza;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmboQuantP1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmboItem;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearList;
    }
}