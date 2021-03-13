using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TROLLICUS__
{
	// Token: 0x02000014 RID: 20
	internal sealed partial class #=q6pdq00PkTschnXgZ4_pqmonZXpgR90pj2oBAr7MJFB8= : Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00004D44 File Offset: 0x00002F44
		public #=q6pdq00PkTschnXgZ4_pqmonZXpgR90pj2oBAr7MJFB8=(string #=zBPb3KhA=, string #=zur7PLhI=)
		{
			if (8 == 0)
			{
			}
			if (7 == 0)
			{
			}
			if (3 == 0)
			{
			}
			this..ctor(#=zBPb3KhA=, #=zur7PLhI=, MessageBoxButtons.OK);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004D74 File Offset: 0x00002F74
		public #=q6pdq00PkTschnXgZ4_pqmonZXpgR90pj2oBAr7MJFB8=(string #=zBPb3KhA=, string #=zur7PLhI=, MessageBoxButtons #=zBkMjrJ4=)
		{
			if (8 == 0)
			{
			}
			if (6 == 0)
			{
			}
			if (4 == 0)
			{
			}
			this..ctor(#=zBPb3KhA=, #=zur7PLhI=, #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706717), #=zBkMjrJ4=);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004DB0 File Offset: 0x00002FB0
		public #=q6pdq00PkTschnXgZ4_pqmonZXpgR90pj2oBAr7MJFB8=(string #=zBPb3KhA=, string #=zur7PLhI=, string #=zBkMjrJ4=, MessageBoxButtons #=zt$cqECc=)
		{
			Label label = new Label();
			Label label2;
			if (6 != 0)
			{
				label2 = label;
			}
			PictureBox pictureBox = new PictureBox();
			PictureBox pictureBox2;
			if (-1 != 0)
			{
				pictureBox2 = pictureBox;
			}
			if (6 != 0)
			{
				base.SuspendLayout();
			}
			pictureBox2.Image = #=q6pdq00PkTschnXgZ4_pqmonZXpgR90pj2oBAr7MJFB8=.#=zCoyqVZbs37kdtY_C_Y0wYGQ=(#=zBkMjrJ4=);
			pictureBox2.Location = new Point(8, 8);
			pictureBox2.Size = new Size(48, 48);
			pictureBox2.TabStop = false;
			label2.Location = new Point(64, 24);
			label2.Size = new Size(310, 114);
			label2.Text = #=zBPb3KhA=;
			if (#=zt$cqECc= != MessageBoxButtons.OK)
			{
				if (#=zt$cqECc= == MessageBoxButtons.YesNo)
				{
					this.#=zwKgDIIdyudLROhuqY0NdySsM3aVCkblNdBsI64E=();
				}
			}
			else
			{
				this.#=zt8USv5DIpIcMX1jlhzREUPnQQt1k();
			}
			this.AutoScaleBaseSize = new Size(5, 13);
			base.ClientSize = new Size(388, 197);
			base.Controls.AddRange(new Control[]
			{
				label2,
				pictureBox2
			});
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.Text = #=zur7PLhI=;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004EC8 File Offset: 0x000030C8
		private void #=zt8USv5DIpIcMX1jlhzREUPnQQt1k()
		{
			Button button = new Button();
			button.FlatStyle = FlatStyle.System;
			button.Location = new Point(169, 162);
			button.TabIndex = 0;
			button.Text = #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706697);
			button.DialogResult = DialogResult.OK;
			Button button2;
			if (4 != 0)
			{
				button2 = button;
			}
			button2.Click += this.#=zE9NRPJawnbDfUbFtcUiieTyBAckPaCUQFVc7u9o=;
			base.Controls.Add(button2);
			IButtonControl acceptButton = button2;
			if (7 != 0)
			{
				base.AcceptButton = acceptButton;
			}
			IButtonControl cancelButton = button2;
			if (6 != 0)
			{
				base.CancelButton = cancelButton;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004F58 File Offset: 0x00003158
		private void #=zE9NRPJawnbDfUbFtcUiieTyBAckPaCUQFVc7u9o=(object #=zBPb3KhA=, EventArgs #=zur7PLhI=)
		{
			if (3 != 0)
			{
				base.Close();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004F74 File Offset: 0x00003174
		private void #=zwKgDIIdyudLROhuqY0NdySsM3aVCkblNdBsI64E=()
		{
			Button button = new Button();
			button.FlatStyle = FlatStyle.System;
			button.Location = new Point(124, 162);
			button.TabIndex = 1;
			button.Text = #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706678);
			button.DialogResult = DialogResult.Yes;
			Button button2;
			if (!false)
			{
				button2 = button;
			}
			Button button3 = new Button();
			button3.FlatStyle = FlatStyle.System;
			button3.Location = new Point(214, 162);
			button3.TabIndex = 0;
			button3.Text = #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706684);
			button3.DialogResult = DialogResult.No;
			Button button4;
			if (-1 != 0)
			{
				button4 = button3;
			}
			base.Controls.AddRange(new Control[]
			{
				button2,
				button4
			});
			IButtonControl acceptButton = button2;
			if (true)
			{
				base.AcceptButton = acceptButton;
			}
			base.CancelButton = button4;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000503C File Offset: 0x0000323C
		private static Bitmap #=zCoyqVZbs37kdtY_C_Y0wYGQ=(string #=zBPb3KhA=)
		{
			Stream manifestResourceStream = typeof(#=q6pdq00PkTschnXgZ4_pqmonZXpgR90pj2oBAr7MJFB8=).Assembly.GetManifestResourceStream(#=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706661) + #=zBPb3KhA= + #=q$vSkDa3Mji4xCpz7q61yxN9ohf90b4BSUMlMYCqxJFs=.#=zC$cvsu0=(1976706623));
			Stream stream;
			if (5 != 0)
			{
				stream = manifestResourceStream;
			}
			if (stream != null)
			{
				return new Bitmap(stream);
			}
			return null;
		}
	}
}
