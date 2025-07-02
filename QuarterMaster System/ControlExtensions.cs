using System.Drawing;
using System.Windows.Forms;
using System;

public static class ControlExtensions
{
    /// <summary>
    /// Adjusts the control's font size to fit its client area, up to an optional maximum font size.
    /// Works for any Control with a Text property (Label, Button, etc).
    /// </summary>
    /// <param name="control">The control to auto-fit.</param>
    /// <param name="maxFontSize">Optional maximum font size. If not specified, defaults to 100.</param>
    public static void AutoFitFont(this Control control, int maxFontSize = 100)
    {
        if (string.IsNullOrEmpty(control.Text)) return;

        int fontSize = maxFontSize;
        Size proposedSize = control.ClientSize;
        Font bestFit = control.Font;

        for (int size = fontSize; size > 1; size--)
        {
            using (Font testFont = new Font(control.Font.FontFamily, size, control.Font.Style))
            {
                Size textSize = TextRenderer.MeasureText(control.Text, testFont);
                if (textSize.Width <= proposedSize.Width && textSize.Height <= proposedSize.Height)
                {
                    bestFit = new Font(control.Font.FontFamily, size, control.Font.Style);
                    break;
                }
            }
        }
        control.Font = bestFit;
    }

    /// <summary>
    /// Adjusts the TextBox's width to fit its current text content.
    /// Optionally, you can set a maximum width.
    /// </summary>
    /// <param name="textBox">The TextBox to auto-size.</param>
    /// <param name="maxWidth">Optional maximum width in pixels.</param>
    public static void AutoSizeToText(this TextBox textBox, int maxWidth = 1000)
    {
        if (textBox == null) return;

        // Measure the text size using the current font
        Size textSize = TextRenderer.MeasureText(textBox.Text + " ", textBox.Font);

        // Set the new width, constrained by maxWidth
        int newWidth = Math.Min(textSize.Width + 1, maxWidth); // +1 for padding
        textBox.Width = newWidth;
    }
}