
namespace Sorts
{
    partial class Lab4Form
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
            this.lab0Menu = new System.Windows.Forms.MenuStrip();
            this.launchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьТочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайнаяГенерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingArrayGrid = new System.Windows.Forms.DataGridView();
            this.sortingsChoose = new System.Windows.Forms.CheckedListBox();
            this.lab0Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingArrayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lab0Menu
            // 
            this.lab0Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchButton,
            this.импортироватьТочкиToolStripMenuItem,
            this.exitButton});
            this.lab0Menu.Location = new System.Drawing.Point(0, 0);
            this.lab0Menu.Name = "lab0Menu";
            this.lab0Menu.Size = new System.Drawing.Size(947, 24);
            this.lab0Menu.TabIndex = 11;
            // 
            // launchButton
            // 
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(57, 20);
            this.launchButton.Text = "Запуск";
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_click);
            // 
            // импортироватьТочкиToolStripMenuItem
            // 
            this.импортироватьТочкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleSheetsToolStripMenuItem,
            this.mSExcelToolStripMenuItem,
            this.случайнаяГенерацияToolStripMenuItem});
            this.импортироватьТочкиToolStripMenuItem.Name = "импортироватьТочкиToolStripMenuItem";
            this.импортироватьТочкиToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.импортироватьТочкиToolStripMenuItem.Text = "Импортировать массив";
            // 
            // googleSheetsToolStripMenuItem
            // 
            this.googleSheetsToolStripMenuItem.Name = "googleSheetsToolStripMenuItem";
            this.googleSheetsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.googleSheetsToolStripMenuItem.Text = "Google Sheets";
            this.googleSheetsToolStripMenuItem.Click += new System.EventHandler(this.googleSheetsToolStripMenuItem_Click);
            // 
            // mSExcelToolStripMenuItem
            // 
            this.mSExcelToolStripMenuItem.Name = "mSExcelToolStripMenuItem";
            this.mSExcelToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.mSExcelToolStripMenuItem.Text = "MS Excel";
            this.mSExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelImport_Click);
            // 
            // случайнаяГенерацияToolStripMenuItem
            // 
            this.случайнаяГенерацияToolStripMenuItem.Name = "случайнаяГенерацияToolStripMenuItem";
            this.случайнаяГенерацияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.случайнаяГенерацияToolStripMenuItem.Text = "Случайная генерация";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 20);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.CloseButton_click);
            // 
            // sortingArrayGrid
            // 
            this.sortingArrayGrid.AllowUserToAddRows = false;
            this.sortingArrayGrid.AllowUserToOrderColumns = true;
            this.sortingArrayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortingArrayGrid.Location = new System.Drawing.Point(12, 27);
            this.sortingArrayGrid.Name = "sortingArrayGrid";
            this.sortingArrayGrid.Size = new System.Drawing.Size(923, 47);
            this.sortingArrayGrid.TabIndex = 13;
            // 
            // sortingsChoose
            // 
            this.sortingsChoose.FormattingEnabled = true;
            this.sortingsChoose.Items.AddRange(new object[] {
            "Пузырьковая сортировка",
            "Сортировка вставками",
            "Шейкерная сортировка",
            "Быстрая сортировка",
            "BOGO"});
            this.sortingsChoose.Location = new System.Drawing.Point(12, 80);
            this.sortingsChoose.Name = "sortingsChoose";
            this.sortingsChoose.Size = new System.Drawing.Size(157, 79);
            this.sortingsChoose.TabIndex = 14;
            // 
            // Lab4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 461);
            this.Controls.Add(this.sortingsChoose);
            this.Controls.Add(this.sortingArrayGrid);
            this.Controls.Add(this.lab0Menu);
            this.MainMenuStrip = this.lab0Menu;
            this.Name = "Lab4Form";
            this.Text = "Сортировки";
            this.lab0Menu.ResumeLayout(false);
            this.lab0Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingArrayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip lab0Menu;
        private System.Windows.Forms.ToolStripMenuItem launchButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.DataGridView sortingArrayGrid;
        private System.Windows.Forms.ToolStripMenuItem импортироватьТочкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайнаяГенерацияToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox sortingsChoose;
    }
}

