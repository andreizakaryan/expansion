namespace Expansion
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.depth1Numeric = new System.Windows.Forms.NumericUpDown();
            this.strategy1Combo = new System.Windows.Forms.ComboBox();
            this.name1Box = new System.Windows.Forms.TextBox();
            this.player1Type = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depth2Numeric = new System.Windows.Forms.NumericUpDown();
            this.strategy2Combo = new System.Windows.Forms.ComboBox();
            this.name2Box = new System.Windows.Forms.TextBox();
            this.player2Type = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.sizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.colorsNumeric = new System.Windows.Forms.NumericUpDown();
            this.quitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth1Numeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.depth1Numeric);
            this.groupBox1.Controls.Add(this.strategy1Combo);
            this.groupBox1.Controls.Add(this.name1Box);
            this.groupBox1.Controls.Add(this.player1Type);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Player";
            // 
            // depth1Numeric
            // 
            this.depth1Numeric.Location = new System.Drawing.Point(38, 121);
            this.depth1Numeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.depth1Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depth1Numeric.Name = "depth1Numeric";
            this.depth1Numeric.Size = new System.Drawing.Size(120, 20);
            this.depth1Numeric.TabIndex = 4;
            this.depth1Numeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // strategy1Combo
            // 
            this.strategy1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strategy1Combo.FormattingEnabled = true;
            this.strategy1Combo.Items.AddRange(new object[] {
            "Random ",
            "Alpha-Beta"});
            this.strategy1Combo.Location = new System.Drawing.Point(38, 94);
            this.strategy1Combo.Name = "strategy1Combo";
            this.strategy1Combo.Size = new System.Drawing.Size(121, 21);
            this.strategy1Combo.TabIndex = 3;
            this.strategy1Combo.Visible = false;
            this.strategy1Combo.SelectedIndexChanged += new System.EventHandler(this.strategy1Combo_SelectedIndexChanged);
            // 
            // name1Box
            // 
            this.name1Box.Location = new System.Drawing.Point(38, 41);
            this.name1Box.Name = "name1Box";
            this.name1Box.Size = new System.Drawing.Size(121, 20);
            this.name1Box.TabIndex = 2;
            this.name1Box.TextChanged += new System.EventHandler(this.name1Box_TextChanged);
            // 
            // player1Type
            // 
            this.player1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player1Type.FormattingEnabled = true;
            this.player1Type.Items.AddRange(new object[] {
            "Human",
            "Bot"});
            this.player1Type.Location = new System.Drawing.Point(38, 67);
            this.player1Type.Name = "player1Type";
            this.player1Type.Size = new System.Drawing.Size(121, 21);
            this.player1Type.TabIndex = 0;
            this.player1Type.SelectedIndexChanged += new System.EventHandler(this.player1Type_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depth2Numeric);
            this.groupBox2.Controls.Add(this.strategy2Combo);
            this.groupBox2.Controls.Add(this.name2Box);
            this.groupBox2.Controls.Add(this.player2Type);
            this.groupBox2.Location = new System.Drawing.Point(263, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Player";
            // 
            // depth2Numeric
            // 
            this.depth2Numeric.Location = new System.Drawing.Point(44, 121);
            this.depth2Numeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.depth2Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depth2Numeric.Name = "depth2Numeric";
            this.depth2Numeric.Size = new System.Drawing.Size(120, 20);
            this.depth2Numeric.TabIndex = 5;
            this.depth2Numeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // strategy2Combo
            // 
            this.strategy2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strategy2Combo.FormattingEnabled = true;
            this.strategy2Combo.Items.AddRange(new object[] {
            "Random ",
            "Alpha-Beta"});
            this.strategy2Combo.Location = new System.Drawing.Point(43, 94);
            this.strategy2Combo.Name = "strategy2Combo";
            this.strategy2Combo.Size = new System.Drawing.Size(121, 21);
            this.strategy2Combo.TabIndex = 4;
            this.strategy2Combo.Visible = false;
            this.strategy2Combo.SelectedIndexChanged += new System.EventHandler(this.strategy2Combo_SelectedIndexChanged);
            // 
            // name2Box
            // 
            this.name2Box.Location = new System.Drawing.Point(43, 41);
            this.name2Box.Name = "name2Box";
            this.name2Box.Size = new System.Drawing.Size(121, 20);
            this.name2Box.TabIndex = 1;
            this.name2Box.TextChanged += new System.EventHandler(this.name2Box_TextChanged);
            // 
            // player2Type
            // 
            this.player2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player2Type.FormattingEnabled = true;
            this.player2Type.Items.AddRange(new object[] {
            "Human",
            "Bot"});
            this.player2Type.Location = new System.Drawing.Point(43, 67);
            this.player2Type.Name = "player2Type";
            this.player2Type.Size = new System.Drawing.Size(121, 21);
            this.player2Type.TabIndex = 0;
            this.player2Type.SelectedIndexChanged += new System.EventHandler(this.player2Type_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(141, 302);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sizeNumeric
            // 
            this.sizeNumeric.Location = new System.Drawing.Point(222, 214);
            this.sizeNumeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sizeNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sizeNumeric.Name = "sizeNumeric";
            this.sizeNumeric.Size = new System.Drawing.Size(59, 20);
            this.sizeNumeric.TabIndex = 3;
            this.sizeNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // colorsNumeric
            // 
            this.colorsNumeric.Location = new System.Drawing.Point(222, 249);
            this.colorsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorsNumeric.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colorsNumeric.Name = "colorsNumeric";
            this.colorsNumeric.Size = new System.Drawing.Size(59, 20);
            this.colorsNumeric.TabIndex = 4;
            this.colorsNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(222, 302);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 5;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numer of colors:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(179, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 337);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.colorsNumeric);
            this.Controls.Add(this.sizeNumeric);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth1Numeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox player1Type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox player2Type;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown sizeNumeric;
        private System.Windows.Forms.NumericUpDown colorsNumeric;
        private System.Windows.Forms.TextBox name1Box;
        private System.Windows.Forms.TextBox name2Box;
        private System.Windows.Forms.ComboBox strategy1Combo;
        private System.Windows.Forms.ComboBox strategy2Combo;
        private System.Windows.Forms.NumericUpDown depth1Numeric;
        private System.Windows.Forms.NumericUpDown depth2Numeric;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}