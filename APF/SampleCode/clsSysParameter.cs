using System;
using System.Data;
using System.Data.SqlClient;

namespace ClsYMTContract
{
	/// <summary>
	/// Summary description for clsSysParameter.
	/// </summary>
	public class clsSysParameter
	{
		public clsSysParameter()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public SqlDataReader getSysParameter(SqlConnection v_objConn,string v_strParameterClass)
		{
			v_strParameterClass=v_strParameterClass.Replace("'","''").Trim().ToString();

			string strSql="";

			strSql+="select ";
			strSql+="	ParameterClass,";
			strSql+="	ParameterName,";
			strSql+="	ParameterValue,";
			strSql+="	ParameterDesrciption,";
			strSql+="	RegDate ";
			strSql+="from ";
			strSql+="	SysParameter WITH (NOLOCK) ";
			strSql+="where ";
			strSql+="	ParameterClass='" + v_strParameterClass + "'";

			SqlCommand objCmd=new SqlCommand(strSql,v_objConn);
			objCmd.CommandTimeout=180;
			try
			{
				return objCmd.ExecuteReader();
			}
			catch(Exception ex)
			{
				throw ex;	
			}
			finally
			{

			}
		}

		public SqlDataReader getSysParameter(SqlConnection v_objConn,string v_strParameterClass,string v_strParameterName)
		{
			v_strParameterClass=v_strParameterClass.Replace("'","''").Trim().ToString();
			v_strParameterName=v_strParameterName.Replace("'","''").Trim().ToString();

			string strSql="";

			strSql+="select ";
			strSql+="	ParameterClass,";
			strSql+="	ParameterName,";
			strSql+="	ParameterValue,";
			strSql+="	ParameterDesrciption,";
			strSql+="	RegDate ";
			strSql+="from ";
			strSql+="	SysParameter WITH (NOLOCK) ";
			strSql+="where ";
			strSql+="	ParameterClass='" + v_strParameterClass + "' and ";
			strSql+="	ParameterName='" + v_strParameterName + "'";

			SqlCommand objCmd=new SqlCommand(strSql,v_objConn);
			objCmd.CommandTimeout=180;
			try
			{
				return objCmd.ExecuteReader();
			}
			catch(Exception ex)
			{
				throw ex;	
			}
			finally
			{

			}
		}

		public SqlDataReader getSysParameter(SqlConnection v_objConn,string v_strParameterClass,string v_strParameterName,string v_strParameterValue)
		{
			v_strParameterClass=v_strParameterClass.Replace("'","''").Trim().ToString();
			v_strParameterName=v_strParameterName.Replace("'","''").Trim().ToString();
			v_strParameterValue=v_strParameterValue.Replace("'","''").Trim().ToString();

			string strSql="";

			strSql+="select ";
			strSql+="	ParameterClass,";
			strSql+="	ParameterName,";
			strSql+="	ParameterValue,";
			strSql+="	ParameterDesrciption,";
			strSql+="	RegDate ";
			strSql+="from ";
			strSql+="	SysParameter WITH (NOLOCK) ";
			strSql+="where ";
			strSql+="	ParameterClass='" + v_strParameterClass + "' and ";
			strSql+="	ParameterName='" + v_strParameterName + "' and ";
			strSql+="	ParameterValue='" + v_strParameterValue + "'";

			SqlCommand objCmd=new SqlCommand(strSql,v_objConn);
			objCmd.CommandTimeout=180;
			try
			{
				return objCmd.ExecuteReader();
			}
			catch(Exception ex)
			{
				throw ex;	
			}
			finally
			{

			}
		}
	}
}
