using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Util
{
	public class Campo
	{
		private static string _Mensaje;
		public static string Mensaje
		{
			get	{return _Mensaje;}
			set	{_Mensaje = value;}
		}
		public enum tipo { EMAIL, DNI, INDICE, ID, FECHA, HORA, FECHAHORA, OTRO }

		static bool invalid = false;

		public static bool ValidaCampo(tipo tipoCampo, string campo)
		{
			if (String.IsNullOrEmpty(campo))
			{
				Mensaje = "Complete los campos requeridos por favor";
				return false;
			}
			switch (tipoCampo)
			{
				//case tipo.EMAIL: return IsValidEmail(); 
				case tipo.DNI: return ValidaDNI(campo);
				case tipo.INDICE: return ValidaIndice(campo);
				case tipo.ID: return ValidaID(campo);
				//case tipo.HORA: return ValidaHora(campo);
				//case tipo.FECHAHORA: return ValidaFechaHora(campo);
				//case tipo.OTRO: return ValidaOtro(campo);
				default:break;
			}
			return true;
		}

		private static bool ValidaDNI(string dni)
		{
			bool correcto = Regex.IsMatch(dni, "[0-9]+");
			if (!correcto)
			{
				Mensaje = "Dni invalido";
			}
			return correcto;
		}
		private static bool ValidaIndice(string indice)
		{
			bool correcto = Regex.IsMatch(indice, "[1-9][0-9]*");
			if (!correcto)
			{
				Mensaje = "El indice debe tener un valor numerico mayor a 0";
			}
			return correcto;
		}
		private static bool ValidaID(string id)
		{
			bool correcto = Regex.IsMatch(id, "[1-9][0-9]*");
			if (!correcto)
			{
				Mensaje = "El id debe tener un valor numerico mayor a 0";
			}
			return correcto;
		}
		//private static bool ValidaHora(string hora)
		//{
			
		//	SimpleDateFormat formatter = new SimpleDateFormat("HH:mm:ss");
		//	try
		//	{
		//		formatter.setLenient(false);
		//		formatter.parse(hora);
		//	}
		//	catch (ParseException pe)
		//	{
		//		Mensaje = "Hora invalida\n" + hora;
		//		return false;
		//	}
		//	return true;
		//}






		public static bool IsValidEmail(string strIn)
		{
			invalid = false;
			if (String.IsNullOrEmpty(strIn))
				return false;

			// Use IdnMapping class to convert Unicode domain names.
			try
			{
				strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
									  RegexOptions.None, TimeSpan.FromMilliseconds(200));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
			if (invalid)
				return false;
			// Return true if strIn is in valid email format.
			try
			{
				return Regex.IsMatch(strIn,
					  @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
					  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
					  RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

		private static string DomainMapper(Match match)
		{
			// IdnMapping class with default property values.
			IdnMapping idn = new IdnMapping();

			string domainName = match.Groups[2].Value;
			try
			{
				domainName = idn.GetAscii(domainName);
			}
			catch (ArgumentException)
			{
				invalid = true;
			}
			return match.Groups[1].Value + domainName;
		}

		public static bool IsValidNumero(String cadena)
		{
			return Regex.IsMatch(cadena, "[1-9][0-9]*");
		}



	}
}