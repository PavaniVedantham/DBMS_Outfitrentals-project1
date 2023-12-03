using System;

namespace Outfit
{
    partial class Outfit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TypeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.BrandTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.DressCodeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.AvailabilityCb = new System.Windows.Forms.ComboBox();
            this.OutfitsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutfitsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 110);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(890, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(387, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Outfits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "OUTFIT RENTAL SYSTEM";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(130, 534);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 38);
            this.button4.TabIndex = 22;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(262, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 21;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(152, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(34, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TypeTb
            // 
            this.TypeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TypeTb.ForeColor = System.Drawing.Color.Red;
            this.TypeTb.HintForeColor = System.Drawing.Color.Empty;
            this.TypeTb.HintText = "";
            this.TypeTb.isPassword = false;
            this.TypeTb.LineFocusedColor = System.Drawing.Color.White;
            this.TypeTb.LineIdleColor = System.Drawing.Color.DarkCyan;
            this.TypeTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.TypeTb.LineThickness = 3;
            this.TypeTb.Location = new System.Drawing.Point(130, 264);
            this.TypeTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TypeTb.Name = "TypeTb";
            this.TypeTb.Size = new System.Drawing.Size(200, 36);
            this.TypeTb.TabIndex = 18;
            this.TypeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.8F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Type";
            // 
            // BrandTb
            // 
            this.BrandTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BrandTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BrandTb.ForeColor = System.Drawing.Color.Red;
            this.BrandTb.HintForeColor = System.Drawing.Color.Empty;
            this.BrandTb.HintText = "";
            this.BrandTb.isPassword = false;
            this.BrandTb.LineFocusedColor = System.Drawing.Color.White;
            this.BrandTb.LineIdleColor = System.Drawing.Color.DarkCyan;
            this.BrandTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.BrandTb.LineThickness = 3;
            this.BrandTb.Location = new System.Drawing.Point(130, 201);
            this.BrandTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BrandTb.Name = "BrandTb";
            this.BrandTb.Size = new System.Drawing.Size(200, 36);
            this.BrandTb.TabIndex = 16;
            this.BrandTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.8F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Brand";
            // 
            // DressCodeTb
            // 
            this.DressCodeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DressCodeTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DressCodeTb.ForeColor = System.Drawing.Color.Red;
            this.DressCodeTb.HintForeColor = System.Drawing.Color.Empty;
            this.DressCodeTb.HintText = "";
            this.DressCodeTb.isPassword = false;
            this.DressCodeTb.LineFocusedColor = System.Drawing.Color.White;
            this.DressCodeTb.LineIdleColor = System.Drawing.Color.DarkCyan;
            this.DressCodeTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.DressCodeTb.LineThickness = 3;
            this.DressCodeTb.Location = new System.Drawing.Point(130, 137);
            this.DressCodeTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DressCodeTb.Name = "DressCodeTb";
            this.DressCodeTb.Size = new System.Drawing.Size(200, 36);
            this.DressCodeTb.TabIndex = 14;
            this.DressCodeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.8F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "DressCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.8F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PriceTb.ForeColor = System.Drawing.Color.Red;
            this.PriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTb.HintText = "";
            this.PriceTb.isPassword = false;
            this.PriceTb.LineFocusedColor = System.Drawing.Color.White;
            this.PriceTb.LineIdleColor = System.Drawing.Color.DarkCyan;
            this.PriceTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.PriceTb.LineThickness = 3;
            this.PriceTb.Location = new System.Drawing.Point(130, 324);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(200, 36);
            this.PriceTb.TabIndex = 24;
            this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.8F);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(12, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Availability";
            // 
            // AvailabilityCb
            // 
            this.AvailabilityCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AvailabilityCb.FormattingEnabled = true;
            this.AvailabilityCb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.AvailabilityCb.Location = new System.Drawing.Point(130, 400);
            this.AvailabilityCb.Name = "AvailabilityCb";
            this.AvailabilityCb.Size = new System.Drawing.Size(197, 33);
            this.AvailabilityCb.TabIndex = 26;
            this.AvailabilityCb.SelectedIndexChanged += new System.EventHandler(this.AvailabilityCb_SelectedIndexChanged);
            // 
            // OutfitsDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.OutfitsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OutfitsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutfitsDGV.BackgroundColor = System.Drawing.Color.White;
            this.OutfitsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutfitsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OutfitsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutfitsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OutfitsDGV.ColumnHeadersHeight = 22;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OutfitsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.OutfitsDGV.EnableHeadersVisualStyles = false;
            this.OutfitsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OutfitsDGV.Location = new System.Drawing.Point(392, 178);
            this.OutfitsDGV.Name = "OutfitsDGV";
            this.OutfitsDGV.RowHeadersVisible = false;
            this.OutfitsDGV.RowHeadersWidth = 51;
            this.OutfitsDGV.RowTemplate.Height = 24;
            this.OutfitsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OutfitsDGV.Size = new System.Drawing.Size(515, 403);
            this.OutfitsDGV.TabIndex = 27;
            this.OutfitsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OutfitsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OutfitsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OutfitsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OutfitsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OutfitsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OutfitsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OutfitsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OutfitsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.NavajoWhite;
            this.OutfitsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OutfitsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OutfitsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OutfitsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OutfitsDGV.ThemeStyle.HeaderStyle.Height = 22;
            this.OutfitsDGV.ThemeStyle.ReadOnly = false;
            this.OutfitsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OutfitsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OutfitsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OutfitsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OutfitsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.OutfitsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OutfitsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OutfitsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OutfitsDGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(763, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 38);
            this.button5.TabIndex = 29;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Outfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.OutfitsDGV);
            this.Controls.Add(this.AvailabilityCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TypeTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BrandTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DressCodeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Outfit";
            this.Text = "Outfit";
            this.Load += new System.EventHandler(this.Outfit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutfitsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TypeTb;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BrandTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DressCodeTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AvailabilityCb;
        private Guna.UI.WinForms.GunaDataGridView OutfitsDGV;
        private System.Windows.Forms.Button button5;

        public EventHandler Search_SelectionChangeCommitted { get; private set; }
    }
}