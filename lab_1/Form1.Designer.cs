
namespace lab_1
{
    partial class Form_Owner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьФормуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАрхивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разархивироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button_7z = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem,
            this.закрытьФормуToolStripMenuItem,
            this.закрытьФормуToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.файлToolStripMenuItem.Text = "Файл ";
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбратьToolStripMenuItem.Text = "Выбрать...";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // закрытьФормуToolStripMenuItem
            // 
            this.закрытьФормуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьАрхивToolStripMenuItem,
            this.разархивироватьToolStripMenuItem});
            this.закрытьФормуToolStripMenuItem.Name = "закрытьФормуToolStripMenuItem";
            this.закрытьФормуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьФормуToolStripMenuItem.Text = "Архив";
            // 
            // закрытьФормуToolStripMenuItem1
            // 
            this.закрытьФормуToolStripMenuItem1.Name = "закрытьФормуToolStripMenuItem1";
            this.закрытьФормуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.закрытьФормуToolStripMenuItem1.Text = "Закрыть форму";
            this.закрытьФормуToolStripMenuItem1.Click += new System.EventHandler(this.закрытьФормуToolStripMenuItem1_Click);
            // 
            // создатьАрхивToolStripMenuItem
            // 
            this.создатьАрхивToolStripMenuItem.Name = "создатьАрхивToolStripMenuItem";
            this.создатьАрхивToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьАрхивToolStripMenuItem.Text = "Создать архив";
            this.создатьАрхивToolStripMenuItem.Click += new System.EventHandler(this.создатьАрхивToolStripMenuItem_Click);
            // 
            // разархивироватьToolStripMenuItem
            // 
            this.разархивироватьToolStripMenuItem.Name = "разархивироватьToolStripMenuItem";
            this.разархивироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.разархивироватьToolStripMenuItem.Text = "Разархивировать";
            this.разархивироватьToolStripMenuItem.Click += new System.EventHandler(this.разархивироватьToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь файла...";
            // 
            // button_7z
            // 
            this.button_7z.Location = new System.Drawing.Point(25, 104);
            this.button_7z.Name = "button_7z";
            this.button_7z.Size = new System.Drawing.Size(114, 23);
            this.button_7z.TabIndex = 3;
            this.button_7z.Text = "Сжать файл";
            this.button_7z.UseVisualStyleBackColor = true;
            this.button_7z.Click += new System.EventHandler(this.button_7z_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(185, 45);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Сохранить *.txt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 17);
            this.listBox1.TabIndex = 7;
            // 
            // Form_Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 223);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button_7z);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Owner";
            this.Text = "lab1";
            this.Load += new System.EventHandler(this.Form_Owner_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьФормуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАрхивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разархивироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьФормуToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_7z;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

