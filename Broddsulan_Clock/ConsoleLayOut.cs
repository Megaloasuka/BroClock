namespace Broddsulan_Clock
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ConsoleLayOut : TableLayoutPanel
    {
        public ConsoleLayOut()
        {
            base.ColumnStyles.Clear();
            base.RowStyles.Clear();
            base.BorderStyle = BorderStyle.None;
            base.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            base.ColumnCount = 1;
            this.AutoScroll = false;
            this.BackColor = Color.Transparent;
            base.Padding = new Padding(0, 0, 0, 0);
            base.Margin = new Padding(0, 0, 0, 0);
            this.Dock = DockStyle.Fill;
        }
    }
}

