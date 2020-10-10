namespace GlazetForms
{
    partial class Glazet
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.Material = new System.Windows.Forms.ComboBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OneCamera = new System.Windows.Forms.RadioButton();
            this.TwoCamera = new System.Windows.Forms.RadioButton();
            this.Pidvikno = new System.Windows.Forms.CheckBox();
            this.rozrahuvatu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Розміри Вікна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(405, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Склопакет";
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(134, 98);
            this.Width.MaxLength = 12;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(139, 23);
            this.Width.TabIndex = 2;
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            // 
            // Material
            // 
            this.Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Material.Font = new System.Drawing.Font("Corbel", 10F);
            this.Material.FormattingEnabled = true;
            this.Material.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.Material.Location = new System.Drawing.Point(134, 183);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(139, 23);
            this.Material.TabIndex = 4;
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.Location = new System.Drawing.Point(134, 143);
            this.Height.MaxLength = 12;
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(139, 23);
            this.Height.TabIndex = 5;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ширина (см2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Висота (см2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Матеріал";
            // 
            // OneCamera
            // 
            this.OneCamera.AutoSize = true;
            this.OneCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneCamera.Location = new System.Drawing.Point(409, 98);
            this.OneCamera.Name = "OneCamera";
            this.OneCamera.Size = new System.Drawing.Size(125, 21);
            this.OneCamera.TabIndex = 9;
            this.OneCamera.TabStop = true;
            this.OneCamera.Text = "Однокамерний";
            this.OneCamera.UseVisualStyleBackColor = true;
            // 
            // TwoCamera
            // 
            this.TwoCamera.AutoSize = true;
            this.TwoCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoCamera.Location = new System.Drawing.Point(409, 125);
            this.TwoCamera.Name = "TwoCamera";
            this.TwoCamera.Size = new System.Drawing.Size(116, 21);
            this.TwoCamera.TabIndex = 10;
            this.TwoCamera.TabStop = true;
            this.TwoCamera.Text = "Двокамерний";
            this.TwoCamera.UseVisualStyleBackColor = true;
            // 
            // Pidvikno
            // 
            this.Pidvikno.AutoSize = true;
            this.Pidvikno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pidvikno.Location = new System.Drawing.Point(409, 179);
            this.Pidvikno.Name = "Pidvikno";
            this.Pidvikno.Size = new System.Drawing.Size(104, 21);
            this.Pidvikno.TabIndex = 11;
            this.Pidvikno.Text = "Підвіконник";
            this.Pidvikno.UseVisualStyleBackColor = true;
            // 
            // rozrahuvatu
            // 
            this.rozrahuvatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rozrahuvatu.Location = new System.Drawing.Point(357, 245);
            this.rozrahuvatu.Name = "rozrahuvatu";
            this.rozrahuvatu.Size = new System.Drawing.Size(168, 35);
            this.rozrahuvatu.TabIndex = 12;
            this.rozrahuvatu.Text = "Розрахувати";
            this.rozrahuvatu.UseVisualStyleBackColor = true;
            this.rozrahuvatu.Click += new System.EventHandler(this.rozrahuvatu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вартість :";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.ForeColor = System.Drawing.Color.Red;
            this.Price.Location = new System.Drawing.Point(134, 256);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(108, 24);
            this.Price.TabIndex = 14;
            this.Price.Text = "none";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Glazet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 314);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rozrahuvatu);
            this.Controls.Add(this.Pidvikno);
            this.Controls.Add(this.TwoCamera);
            this.Controls.Add(this.OneCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Glazet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlazetForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.ComboBox Material;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton OneCamera;
        private System.Windows.Forms.RadioButton TwoCamera;
        private System.Windows.Forms.CheckBox Pidvikno;
        private System.Windows.Forms.Button rozrahuvatu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Price;
    }
}

