using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PoliceCodes.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00003671 File Offset: 0x00001871
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00003679 File Offset: 0x00001879
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("PoliceCodes.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000036A5 File Offset: 0x000018A5
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000036AC File Offset: 0x000018AC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000D1 RID: 209
		private static ResourceManager resourceMan;

		// Token: 0x040000D2 RID: 210
		private static CultureInfo resourceCulture;
	}
}
