namespace ListBox
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
            this.feltoltottLista = new System.Windows.Forms.ListBox();
            this.beviteliTB = new System.Windows.Forms.TextBox();
            this.szamlalo = new System.Windows.Forms.NumericUpDown();
            this.felveszBtn = new System.Windows.Forms.Button();
            this.beszurBtn = new System.Windows.Forms.Button();
            this.torolBtn = new System.Windows.Forms.Button();
            this.torolMindBtn = new System.Windows.Forms.Button();
            this.atmasolBtn = new System.Windows.Forms.Button();
            this.atmozgatBtn = new System.Windows.Forms.Button();
            this.keresBtn = new System.Windows.Forms.Button();
            this.atmasoltLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.szamlalo)).BeginInit();
            this.SuspendLayout();
            // 
            // feltoltottLista
            // 
            this.feltoltottLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feltoltottLista.FormattingEnabled = true;
            this.feltoltottLista.ItemHeight = 22;
            this.feltoltottLista.Location = new System.Drawing.Point(63, 70);
            this.feltoltottLista.Name = "feltoltottLista";
            this.feltoltottLista.Size = new System.Drawing.Size(323, 510);
            this.feltoltottLista.TabIndex = 0;
            // 
            // beviteliTB
            // 
            this.beviteliTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beviteliTB.Location = new System.Drawing.Point(63, 29);
            this.beviteliTB.Name = "beviteliTB";
            this.beviteliTB.Size = new System.Drawing.Size(323, 28);
            this.beviteliTB.TabIndex = 1;
            // 
            // szamlalo
            // 
            this.szamlalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamlalo.Location = new System.Drawing.Point(415, 30);
            this.szamlalo.Name = "szamlalo";
            this.szamlalo.Size = new System.Drawing.Size(75, 28);
            this.szamlalo.TabIndex = 2;
            this.szamlalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // felveszBtn
            // 
            this.felveszBtn.Location = new System.Drawing.Point(415, 70);
            this.felveszBtn.Name = "felveszBtn";
            this.felveszBtn.Size = new System.Drawing.Size(75, 23);
            this.felveszBtn.TabIndex = 3;
            this.felveszBtn.Text = "Felvesz";
            this.felveszBtn.UseVisualStyleBackColor = true;
            this.felveszBtn.Click += new System.EventHandler(this.FelveszBtn_Click);
            // 
            // beszurBtn
            // 
            this.beszurBtn.Location = new System.Drawing.Point(415, 149);
            this.beszurBtn.Name = "beszurBtn";
            this.beszurBtn.Size = new System.Drawing.Size(75, 23);
            this.beszurBtn.TabIndex = 4;
            this.beszurBtn.Text = "Beszúr";
            this.beszurBtn.UseVisualStyleBackColor = true;
            this.beszurBtn.Click += new System.EventHandler(this.BeszurBtn_Click);
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(415, 228);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(75, 23);
            this.torolBtn.TabIndex = 5;
            this.torolBtn.Text = "Töröl";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Click += new System.EventHandler(this.TorolBtn_Click);
            // 
            // torolMindBtn
            // 
            this.torolMindBtn.Location = new System.Drawing.Point(415, 307);
            this.torolMindBtn.Name = "torolMindBtn";
            this.torolMindBtn.Size = new System.Drawing.Size(75, 23);
            this.torolMindBtn.TabIndex = 6;
            this.torolMindBtn.Text = "Töröl mind";
            this.torolMindBtn.UseVisualStyleBackColor = true;
            this.torolMindBtn.Click += new System.EventHandler(this.TorolMindBtn_Click);
            // 
            // atmasolBtn
            // 
            this.atmasolBtn.Location = new System.Drawing.Point(415, 386);
            this.atmasolBtn.Name = "atmasolBtn";
            this.atmasolBtn.Size = new System.Drawing.Size(75, 23);
            this.atmasolBtn.TabIndex = 7;
            this.atmasolBtn.Text = "Átmásol";
            this.atmasolBtn.UseVisualStyleBackColor = true;
            this.atmasolBtn.Click += new System.EventHandler(this.AtmasolBtn_Click);
            // 
            // atmozgatBtn
            // 
            this.atmozgatBtn.Location = new System.Drawing.Point(415, 465);
            this.atmozgatBtn.Name = "atmozgatBtn";
            this.atmozgatBtn.Size = new System.Drawing.Size(75, 23);
            this.atmozgatBtn.TabIndex = 8;
            this.atmozgatBtn.Text = "Átmozgat";
            this.atmozgatBtn.UseVisualStyleBackColor = true;
            this.atmozgatBtn.Click += new System.EventHandler(this.AtmozgatBtn_Click);
            // 
            // keresBtn
            // 
            this.keresBtn.Location = new System.Drawing.Point(415, 544);
            this.keresBtn.Name = "keresBtn";
            this.keresBtn.Size = new System.Drawing.Size(75, 23);
            this.keresBtn.TabIndex = 9;
            this.keresBtn.Text = "Keres";
            this.keresBtn.UseVisualStyleBackColor = true;
            this.keresBtn.Click += new System.EventHandler(this.KeresBtn_Click);
            // 
            // atmasoltLista
            // 
            this.atmasoltLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.atmasoltLista.FormattingEnabled = true;
            this.atmasoltLista.ItemHeight = 22;
            this.atmasoltLista.Location = new System.Drawing.Point(518, 70);
            this.atmasoltLista.Name = "atmasoltLista";
            this.atmasoltLista.Size = new System.Drawing.Size(335, 510);
            this.atmasoltLista.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 702);
            this.Controls.Add(this.atmasoltLista);
            this.Controls.Add(this.keresBtn);
            this.Controls.Add(this.atmozgatBtn);
            this.Controls.Add(this.atmasolBtn);
            this.Controls.Add(this.torolMindBtn);
            this.Controls.Add(this.torolBtn);
            this.Controls.Add(this.beszurBtn);
            this.Controls.Add(this.felveszBtn);
            this.Controls.Add(this.szamlalo);
            this.Controls.Add(this.beviteliTB);
            this.Controls.Add(this.feltoltottLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.szamlalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox feltoltottLista;
        private System.Windows.Forms.TextBox beviteliTB;
        private System.Windows.Forms.NumericUpDown szamlalo;
        private System.Windows.Forms.Button felveszBtn;
        private System.Windows.Forms.Button beszurBtn;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button torolMindBtn;
        private System.Windows.Forms.Button atmasolBtn;
        private System.Windows.Forms.Button atmozgatBtn;
        private System.Windows.Forms.Button keresBtn;
        private System.Windows.Forms.ListBox atmasoltLista;
    }
}

