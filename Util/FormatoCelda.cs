using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util
{
	public class FormatoCelda
	{
		public static void FormatoCeldaParaObjects(object sender, DataGridViewCellFormattingEventArgs e, DataGridView dgv_Personas)
		{
			if ((dgv_Personas.Rows[e.RowIndex].DataBoundItem != null) &&
				(dgv_Personas.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
						{
							e.Value = BindProperty(
										  dgv_Personas.Rows[e.RowIndex].DataBoundItem,
										  dgv_Personas.Columns[e.ColumnIndex].DataPropertyName
										);
			}
		}

		private static string BindProperty(object property, string propertyName)
		{
			string retValue = "";

			if (propertyName.Contains("."))
			{
				PropertyInfo[] arrayProperties;
				string leftPropertyName;

				leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
				arrayProperties = property.GetType().GetProperties();

				foreach (PropertyInfo propertyInfo in arrayProperties)
				{
					if (propertyInfo.Name == leftPropertyName)
					{
						retValue = BindProperty(
						  propertyInfo.GetValue(property, null),
						  propertyName.Substring(propertyName.IndexOf(".") + 1));
						break;
					}
				}
			}
			else
			{
				Type propertyType;
				PropertyInfo propertyInfo;

				propertyType = property.GetType();
				propertyInfo = propertyType.GetProperty(propertyName);
				retValue = propertyInfo.GetValue(property, null).ToString();
			}

			return retValue;
		}
	}
}
