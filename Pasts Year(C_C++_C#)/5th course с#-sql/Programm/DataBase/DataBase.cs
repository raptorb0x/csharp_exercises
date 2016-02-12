using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Programm.Models;
using System.Collections.ObjectModel;
using System.Windows;
using Oracle.DataAccess.Client;
using System.Data;

namespace Programm.DataBase
{
    public static class DataBase
    {
        //connection string = "DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"; 
        public static void GenerateData()
        {
            
        }
       
            
        #region In_Prikaz_Naim

        public static List<In_Prikaz_Naim> GetIn_Prikaz_Naim()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_PRIKAZ_NAIM";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Prikaz_Naim> _in_prikaz_naim = new List<In_Prikaz_Naim>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_prikaz_naim.Add(new In_Prikaz_Naim()
                        {
                            Id =  Convert.ToInt32(row["ID_PRIKAZ"]),
                            DatePr = Convert.ToDateTime(row["DATE_PR"]),
                            PrType = 0.ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        );
                    }
                    return _in_prikaz_naim;
                }
            }
        }

        public static void DeleteIn_Prikaz_Naim(In_Prikaz_Naim elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_PRIKAZ where ID_PRIKAZ = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Prikaz_Naim(In_Prikaz_Naim elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_PRIKAZ (ID_SOTR, DATE_PR, PRIKAZ_TYPE) values ({0}, to_date('{1}', 'yyyy/MM/dd'), 0)", elem.Sotr.Id, elem.DatePr.ToString("yyyy/MM/dd"));
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Prikaz_Naim(In_Prikaz_Naim elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_PRIKAZ set ID_SOTR = {0}, DATE_PR = to_date('{1}', 'yyyy/MM/dd') where ID_PRIKAZ = {2} ", elem.Sotr.Id, elem.DatePr.ToString("yyyy/MM/dd"), elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Prikaz_Perevod

        public static List<In_Prikaz_Perevod> GetIn_Prikaz_Perevod()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_PRIKAZ_PEREVOD";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Prikaz_Perevod> _in_prikaz_naim = new List<In_Prikaz_Perevod>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_prikaz_naim.Add(new In_Prikaz_Perevod()
                        {
                            Id = Convert.ToInt32(row["ID_PRIKAZ"]),
                            DatePr = Convert.ToDateTime(row["DATE_PR"]),
                            PrType = 1.ToString(),
                            OldPodr = new Spr_Struct_Podr()
                            {
                                Id = Convert.ToInt32(row["ID_OLD_PODR"]),
                                Name = row["OLD_PODR_NAME"].ToString()
                            },
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["NEW_PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        );
                    }
                    return _in_prikaz_naim;
                }
            }
        }

        public static void DeleteIn_Prikaz_Perevod(In_Prikaz_Perevod elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_PRIKAZ where ID_PRIKAZ = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Prikaz_Perevod(In_Prikaz_Perevod elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_PRIKAZ (ID_SOTR, DATE_PR, PRIKAZ_TYPE, ID_PODR) values ({0}, to_date('{1}', 'yyyy/MM/dd'), 1, {2})", elem.Sotr.Id, elem.DatePr.ToString("yyyy/MM/dd"), elem.OldPodr.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Prikaz_Perevod(In_Prikaz_Perevod elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_PRIKAZ set ID_SOTR = {0}, DATE_PR = to_date('{1}', 'yyyy/MM/dd'), ID_PODR = {2} where ID_PRIKAZ = {3} ", elem.Sotr.Id, elem.DatePr.ToString("yyyy/MM/dd"), elem.OldPodr.Id, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Prikaz_Uvol

        public static List<In_Prikaz_Uvol> GetIn_Prikaz_Uvol()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_PRIKAZ_UVOL";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Prikaz_Uvol> _in_prikaz_naim = new List<In_Prikaz_Uvol>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_prikaz_naim.Add(new In_Prikaz_Uvol()
                        {
                            Id =  Convert.ToInt32(row["ID_PRIKAZ"]),
                            DatePr = Convert.ToDateTime(row["DATE_PR"]),
                            PrType = 2.ToString(),
                            Prichina = row["PRICHINA"].ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        );
                    }
                    return _in_prikaz_naim;
                }
            }
        }

        public static void DeleteIn_Prikaz_Uvol(In_Prikaz_Uvol elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_PRIKAZ where ID_PRIKAZ = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Prikaz_Uvol(In_Prikaz_Uvol elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_PRIKAZ (ID_SOTR, DATE_PR, PRIKAZ_TYPE, PRICHINA) values ({0}, to_date('{1}', 'yyyy/MM/dd'), 2, '{2}')", elem.Sotr.Id, elem.DatePr.ToString("yyyy/MM/dd"), elem.Prichina);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Prikaz_Uvol(In_Prikaz_Uvol elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_PRIKAZ set ID_SOTR = {0}, DATE_PR = to_date('{1}', 'yyyy/MM/dd'), PRICHINA = '{2}' where ID_PRIKAZ = {3} ", elem.Sotr.Id, elem.DatePr.ToString("yyyy/MM/dd"), elem.Prichina, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Rez_Test

        public static List<In_Rez_Test> GetIn_Rez_Test()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_REZ_TEST";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Rez_Test> _in_rez_test = new List<In_Rez_Test>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_rez_test.Add(new In_Rez_Test()
                        {
                            Id =  Convert.ToInt32(row["ID_REZ_TEST"]),
                            ProhodBall = row["PROHOD_BALL"].ToString(),
                            SummBall = row["BALL"].ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["T_SPR_SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        );
                    }
                    return _in_rez_test;
                }
            }
        }

        public static void DeleteIn_Rez_Test(In_Rez_Test elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_REZ_TEST where ID_REZ_TEST = {0} ", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Rez_Test(In_Rez_Test elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_REZ_TEST (ID_SOTR, BALL, PROHOD_BALL) values ({0}, {1}, {2})", elem.Sotr.Id, elem.SummBall, elem.ProhodBall);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Rez_Test(In_Rez_Test elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_REZ_TEST set ID_SOTR = {0}, BALL = {1}, PROHOD_BALL = {2} where ID_REZ_TEST = {3} ", elem.Sotr.Id, elem.SummBall, elem.ProhodBall, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Out_Rez_Test

        public static List<Out_Rez_Test> GetOut_Rez_Test()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_REZ_TEST";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Rez_Test> _out_rez_test = new List<Out_Rez_Test>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _out_rez_test.Add(new Out_Rez_Test()
                        {
                            Id = Convert.ToInt32(row["ID_REZ_TEST"]),
                            ProhodBall = row["PROHOD_BALL"].ToString(),
                            SummBall = row["BALL"].ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["T_SPR_SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        
                        );
                        _out_rez_test[_out_rez_test.Count - 1].CalcResult();
                    }
                    return _out_rez_test;
                }
            }
        }

        public static Out_Rez_Test GetItogPass()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(ID_REZ_TEST) FROM V_IN_REZ_TEST where BALL >= PROHOD_BALL ";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    return new Out_Rez_Test()
                    {
                        SummBall = "Итого прошло:",
                        Result = dt.Rows[0][0].ToString()
                    };
                }
            }
        }

        public static Out_Rez_Test GetItogNotPass()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(ID_REZ_TEST) FROM V_IN_REZ_TEST where BALL < PROHOD_BALL ";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    return new Out_Rez_Test()
                    {
                        SummBall = "Итого не прошло:",
                        Result = dt.Rows[0][0].ToString()
                    };
                }
            }
        }

        #endregion

        #region Spr_Struct_Podr
        
        public static List<Spr_Struct_Podr> GetSpr_Struct_Podr()
        {

           

            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_SPR_PODR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Struct_Podr> _spr_struct_podr = new List<Spr_Struct_Podr>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_struct_podr.Add(new Spr_Struct_Podr()
                        {
                            Id = Convert.ToInt32(row["ID_PODR"]),
                            Name = row["NAME"].ToString()
                        }
                        );
                    }
                    return _spr_struct_podr;
                }
            }
        }

        public static void DeleteSpr_Struct_Podr(Spr_Struct_Podr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_PODR where ID_PODR = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Struct_Podr(Spr_Struct_Podr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_PODR (NAME) values ('{0}')", elem.Name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Struct_Podr(Spr_Struct_Podr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_PODR set NAME = '{0}' where ID_PODR = {1}", elem.Name, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Org

        public static List<Spr_Org> GetSpr_Org()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_SPR_ORG";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Org> _spr_org = new List<Spr_Org>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_org.Add(new Spr_Org()
                        {
                            Date = row["DATE_PROV"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["DATE_PROV"]),
                            Cost = row["COST"].ToString(),
                            Id =  Convert.ToInt32(row["ID_ORG"]),
                            Name = row["ORG_NAME"].ToString(),
                            Theme = new Spr_Theme()
                            {
                                Id =  Convert.ToInt32(row["ID_THEME"]),
                                Name = row["THEME_NAME"].ToString()
                            }
                        }
                        );
                    }
                    return _spr_org;
                }
            }
        }

        public static void DeleteSpr_Org(Spr_Org elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_ORG where ID_ORG = {0} ", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Org(Spr_Org elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_ORG (ID_THEME, NAME, DATE_PROV, COST) values ({0}, '{1}', to_date('{2}', 'yyyy/MM/dd'), {3})", elem.Theme.Id, elem.Name, elem.Date.Value.ToString("yyyy/MM/dd"), elem.Cost);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Org(Spr_Org elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_ORG set ID_THEME = {0}, NAME = '{1}', DATE_PROV = to_date('{2}', 'yyyy/MM/dd'), COST = {3} where ID_ORG = {4}", elem.Theme.Id, elem.Name, elem.Date.Value.ToString("yyyy/MM/dd"), elem.Cost, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Theme

        public static List<Spr_Theme> GetSpr_Theme()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM T_SPR_THEME";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Theme> _spr_struct_podr = new List<Spr_Theme>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_struct_podr.Add(new Spr_Theme()
                        {
                            Id =  Convert.ToInt32(row["ID_THEME"]),
                            Name = row["NAME"].ToString()
                        }
                        );
                    }
                    return _spr_struct_podr;
                }
            }
        }

        public static void DeleteSpr_Theme(Spr_Theme elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_THEME where ID_THEME = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Theme(Spr_Theme elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_THEME (NAME) values ('{0}')", elem.Name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Theme(Spr_Theme elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_THEME set NAME = '{0}' where ID_THEME = {1}", elem.Name, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Uch_Sotr

        public static List<In_Uch_Sotr> GetIn_Uch_Sotr()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_UCH_SOTR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Uch_Sotr> _in_uch_sotr = new List<In_Uch_Sotr>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_uch_sotr.Add(new In_Uch_Sotr()
                        {
                            DateLA = row["LAST_ATT_DATE"] is DBNull ? new DateTime() : Convert.ToDateTime(row["LAST_ATT_DATE"]),
                            DatePr = row["DATE_PRIEM"] is DBNull ? new DateTime() : Convert.ToDateTime(row["DATE_PRIEM"]),
                            Id =  Convert.ToInt32(row["ID_SOTR"]),
                            Nadbavki = row["NADB"].ToString(),
                            Oklad = row["OKLAD"].ToString(),
                            PrVyp = row["PR_VYPL"].ToString(),
                            Zp = row["ZP"].ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        );
                    }
                    return _in_uch_sotr;
                }
            }
        }
               
        

        public static void EditIn_Uch_Sotr(In_Uch_Sotr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_SOTR set DATE_PRIEM = to_date('{0}', 'yyyy/MM/dd'), LAST_ATT_DATE = to_date('{1}', 'yyyy/MM/dd')  where ID_SOTR = {2} ", elem.DatePr.ToString("yyyy/MM/dd"), elem.DateLA.ToString("yyyy/MM/dd"), elem.Sotr.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Dolj
        public static List<Spr_Dolj> GetSpr_Dolj()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_SPR_DOLJ";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Dolj> _spr_dolj = new List<Spr_Dolj>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_dolj.Add(new Spr_Dolj()
                        {
                            Id = Convert.ToInt32(row["ID_DOLJ"]),
                            Name = row["DOLJ_NAME"].ToString(),
                            Podr = new Spr_Struct_Podr()
                            {
                                Id = Convert.ToInt32(row["ID_PODR"]),
                                Name = row["PODR_NAME"].ToString()
                            }
                        }
                        );
                    }
                   // List<Spr_Dolj> _spr_dolj_List = _spr_dolj.ToList();
                    return _spr_dolj;//_spr_dolj;
                }
            }
        }

        public static void DeleteSpr_Dolj(Spr_Dolj elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_DOLJ where ID_DOLJ = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Dolj(Spr_Dolj elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_DOLJ (ID_PODR, NAME) values ({0}, '{1}')", elem.Podr.Id, elem.Name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Dolj(Spr_Dolj elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_DOLJ set ID_PODR = {0}, NAME = '{1}'  where ID_DOLJ = {2} ", elem.Podr.Id, elem.Name, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Sotr

        public static List<Spr_Sotr> GetSpr_Sotr()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_SPR_SOTR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Sotr> _spr_sotr = new List<Spr_Sotr>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_sotr.Add(new Spr_Sotr()
                        {
                            Id =  Convert.ToInt32(row["ID_SOTR"]),
                            Name = row["SOTR_NAME"].ToString(),
                            Staj = row["STAJ"].ToString(),
                            Dolj = new Spr_Dolj()
                            {
                                Id =  Convert.ToInt32(row["ID_DOLJ"]),
                                Name = row["DOLJ_NAME"].ToString(),
                                Podr = new Spr_Struct_Podr()
                                {
                                    Id = Convert.ToInt32(row["ID_PODR"]),
                                    Name = row["PODR_NAME"].ToString()
                                }
                            }
                        }
                        );
                    }
                    return _spr_sotr;
                }
            }
        }

        public static void DeleteSpr_Sotr(Spr_Sotr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_SOTR where ID_SOTR = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Sotr(Spr_Sotr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_SOTR (ID_DOLJ, NAME, STAJ) values ({0}, '{1}', '{2}')", elem.Dolj.Id, elem.Name, elem.Staj);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Sotr(Spr_Sotr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_SOTR set ID_DOLJ = {0}, NAME = '{1}', STAJ = '{2}'  where ID_SOTR = {3}", elem.Dolj.Id, elem.Name, elem.Staj, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Vid_Rab

        public static List<Spr_Vid_Rab> GetSpr_Vid_Rab()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_SPR_VID_RAB";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Vid_Rab> _spr_vid_rab = new List<Spr_Vid_Rab>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_vid_rab.Add(new Spr_Vid_Rab()
                        {
                            Id =  Convert.ToInt32(row["ID_VID_RAB"]),
                            Name = row["VID_RAB_NAME"].ToString(),
                            EdIzm = row["ED_IZM"].ToString(),
                            Dolj = new Spr_Dolj()
                            {
                                Id =  Convert.ToInt32(row["ID_DOLJ"]),
                                Name = row["DOLJ_NAME"].ToString(),
                                Podr = new Spr_Struct_Podr()
                                {
                                    Id = Convert.ToInt32(row["ID_PODR"]),
                                    Name = row["PODR_NAME"].ToString()
                                }
                            }
                        }
                        );
                    }
                    return _spr_vid_rab;
                }
            }
        }

        public static void DeleteSpr_Vid_Rab(Spr_Vid_Rab elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_VID_RAB where ID_VID_RAB = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Vid_Rab(Spr_Vid_Rab elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_VID_RAB (ID_DOLJ, NAME, ED_IZM) values ({0}, '{1}', '{2}')", elem.Dolj.Id, elem.Name, elem.EdIzm);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Vid_Rab(Spr_Vid_Rab elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_VID_RAB set ID_DOLJ = {0}, NAME = '{1}', ED_IZM = '{2}'  where ID_VID_RAB = {3}", elem.Dolj.Id, elem.Name, elem.EdIzm, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Out Shtat_Rasp
        public static List<Out_Shtat_Rasp> GetOut_Shtat_Rasp()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_SHTAT_RASP";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Shtat_Rasp> _out_shtat_rasp = new List<Out_Shtat_Rasp>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _out_shtat_rasp.Add(new Out_Shtat_Rasp()
                        {
                            Id_Dolj =  Convert.ToInt32(row["ID_DOLJ"]),
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Fond = row["FOND"].ToString(),
                            Nadbavki = row["NADB"].ToString(),
                            Oklad = row["OKLAD"].ToString(),
                            Plan_Kolvo = row["KOLVO_ED_SOTR"].ToString(),
                            Podr_Name = row["PODR_NAME"].ToString(),
                            Pr_Vyplaty = row["PR_VYPL"].ToString()
                        });
                    }
                    return _out_shtat_rasp;
                }
            }
        }
        #endregion

        #region Out Out_Ved_Potr_Kadr
        public static List<Out_Ved_Potr_Kadr> GetOut_Ved_Potr_Kadr()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_VED_POTR_KADR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Ved_Potr_Kadr> _Out_Ved_Potr_Kadr = new List<Out_Ved_Potr_Kadr>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _Out_Ved_Potr_Kadr.Add(new Out_Ved_Potr_Kadr()
                        {
                            Id_Dolj =  Convert.ToInt32(row["ID_DOLJ"]),
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Uch_Kolvo = row["UCH_KOLVO"].ToString(),
                            Plan_Kolvo = row["PLAN_KOLVO"].ToString(),
                            Podr_Name = row["PODR_NAME"].ToString(),
                            Tr_Kolvo = row["TR_KOLVO"].ToString()
                        });
                    }
                    return _Out_Ved_Potr_Kadr;
                }
            }
        }
        #endregion

        #region Out Out_Ved_Dv_Kadr
        public static List<Out_Ved_Dv_Kadr> GetOut_Ved_Dv_Kadr()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_VED_DV_KADR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Ved_Dv_Kadr> _Out_Ved_Dv_Kadr = new List<Out_Ved_Dv_Kadr>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _Out_Ved_Dv_Kadr.Add(new Out_Ved_Dv_Kadr()
                        {
                            Year = row["YEAR"].ToString(),
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Perevedeno = row["KOL_PEREV"].ToString(),
                            Uvoleno = row["KOL_UVOL"].ToString(),
                            Prinyato = row["KOL_NAIM"].ToString(),
                            Podr_Name = row["PODR_NAME"].ToString()
                        });
                    }
                    return _Out_Ved_Dv_Kadr;
                }
            }
        }

        public static Out_Ved_Dv_Kadr GetOut_Ved_Dv_KadrItog()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select sum(KOL_NAIM), sum(KOL_PEREV), sum(KOL_UVOL) from v_out_ved_dv_kadr";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count >= 1)
                    {
                        return new Out_Ved_Dv_Kadr()
                        {
                            Perevedeno = dt.Rows[0][1].ToString(),
                            Uvoleno = dt.Rows[0][2].ToString(),
                            Prinyato = dt.Rows[0][0].ToString(),
                            Dolj_Name = "Итого:"
                        };
                    }
                    else
                        return new Out_Ved_Dv_Kadr()
                        {
                            Dolj_Name = "Итого:"
                        };
                }
            }
        }

        #endregion

        #region Out Out_Plan_Att
        public static List<Out_Plan_Att> GetOut_Plan_Att()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_PLAN_ATT";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Plan_Att> _Out_Plan_Att = new List<Out_Plan_Att>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _Out_Plan_Att.Add(new Out_Plan_Att()
                        {
                            Id_Sotr =  Convert.ToInt32(row["ID_SOTR"]),
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Podr_Name = row["PODR_NAME"].ToString(),
                            SotrName = row["SOTR_NAME"].ToString(),
                            PlanDate = row["PLAN_ATT_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["PLAN_ATT_DATE"].ToString())
                        });
                    }
                    return _Out_Plan_Att;
                }
            }
        }

        #endregion

        #region Out Out_Otchet_Plan_Att
        public static List<Out_Otchet_Plan_Att> GetOut_Otchet_Plan_Att()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_OTCHET_PLAN_ATT";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Otchet_Plan_Att> _Out_Otchet_Plan_Att = new List<Out_Otchet_Plan_Att>();

                    foreach (DataRow row in dt.Rows)
                    {
                        var e = new Out_Otchet_Plan_Att()
                        {
                            Id_Sotr = row["ID_SOTR"].ToString(),
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Podr_Name = row["PODR_NAME"].ToString(),
                            SotrName = row["SOTR_NAME"].ToString(),
                            PlanDate = row["PLAN_ATT_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["PLAN_ATT_DATE"].ToString()),
                            FactDate = row["DATE_ATT"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["DATE_ATT"].ToString()),
                            Ball = row["BALL"].ToString(),
                            MinBall = row["MINBALL"].ToString()
                            //PovtDate = row["POVT_ATT_DATE"] is DBNull ? new DateTime() : Convert.ToDateTime(row["POVT_ATT_DATE"].ToString())
                        };

                        if ((!string.IsNullOrEmpty(e.Ball) && !string.IsNullOrEmpty(e.MinBall)) && (int.Parse(e.MinBall) <= int.Parse(e.Ball)))
                        {
                            e.PovtDate = null;
                        }
                        else
                        {
                            e.PovtDate = row["POVT_ATT_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["POVT_ATT_DATE"].ToString());
                        }

                        _Out_Otchet_Plan_Att.Add(e);
                    }
                    return _Out_Otchet_Plan_Att;
                }
            }
        }

        #endregion

        #region In_Ved_Ob_Rab

        public static List<In_Ved_Ob_Rab> GetIn_Ved_Ob_Rab()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_VED_OB_RAB";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Ved_Ob_Rab> _ved_ob_rab = new List<In_Ved_Ob_Rab>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _ved_ob_rab.Add(new In_Ved_Ob_Rab()
                        {
                            Id =  Convert.ToInt32(row["ID_VED_OB_RAB"]),
                            Kolvo = row["KOLVO"].ToString(),
                            StartDate = Convert.ToDateTime(row["START_DATE"]),
                            FinishDate = Convert.ToDateTime(row["FINISH_DATE"]),
                            VidRab = new Spr_Vid_Rab()
                            {
                                Id =  Convert.ToInt32(row["ID_VID_RAB"]),
                                Name = row["VID_RAB_NAME"].ToString(),
                                EdIzm = row["ED_IZM"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                }
                            }
                        }
                        );
                    }
                    return _ved_ob_rab;
                }
            }
        }

        public static void DeleteIn_Ved_Ob_Rab(In_Ved_Ob_Rab elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_VED_OB_RAB where ID_VED_OB_RAB = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Ved_Ob_Rab(In_Ved_Ob_Rab elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_VED_OB_RAB (ID_VID_RAB, KOLVO, START_DATE, FINISH_DATE) values ({0}, {1}, to_date('{2}', 'yyyy/MM/dd'), to_date('{3}', 'yyyy/MM/dd'))", elem.VidRab.Id, elem.Kolvo, elem.StartDate.ToString("yyyy/MM/dd"), elem.FinishDate.ToString("yyyy/MM/dd"));
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Ved_Ob_Rab(In_Ved_Ob_Rab elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_VED_OB_RAB set ID_VID_RAB = {0}, KOLVO = {1}, START_DATE = to_date('{2}', 'yyyy/MM/dd'), FINISH_DATE = to_date('{3}', 'yyyy/MM/dd')  where ID_VED_OB_RAB = {4} ", elem.VidRab.Id, elem.Kolvo, elem.StartDate.ToString("yyyy/MM/dd"), elem.FinishDate.ToString("yyyy/MM/dd"), elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Ved_Zat_Tr

        public static List<In_Ved_Zat_Tr> GetIn_Ved_Zat_Tr()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_VED_ZAT_TR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Ved_Zat_Tr> _ved_ob_rab = new List<In_Ved_Zat_Tr>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _ved_ob_rab.Add(new In_Ved_Zat_Tr()
                        {
                            Id =  Convert.ToInt32(row["ID_VED_ZAT_TR"]),
                            ChelChas = row["CHEL_CH"].ToString(),
                            ChelDni = row["CHEL_DN"].ToString(),
                            NormVr = row["VR_NORM"].ToString(),
                            VidRab = new Spr_Vid_Rab()
                            {
                                Id =  Convert.ToInt32(row["ID_VID_RAB"]),
                                Name = row["VID_RAB_NAME"].ToString(),
                                EdIzm = row["ED_IZM"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                }
                            }
                        }
                        );
                    }
                    return _ved_ob_rab;
                }
            }
        }

        public static void DeleteIn_Ved_Zat_Tr(In_Ved_Zat_Tr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_VED_ZAT_TR where ID_VED_ZAT_TR = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Ved_Zat_Tr(In_Ved_Zat_Tr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_VED_ZAT_TR (ID_VID_RAB, VR_NORM, CHEL_CH, CHEL_DN) values ({0}, {1}, {2}, {3})", elem.VidRab.Id, elem.NormVr, elem.ChelChas, elem.ChelDni);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Ved_Zat_Tr(In_Ved_Zat_Tr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_VED_ZAT_TR set ID_VID_RAB = {0}, VR_NORM = {1}, CHEL_CH = {2}, CHEL_DN = {3}  where ID_VED_ZAT_TR = {4} ", elem.VidRab.Id, elem.NormVr, elem.ChelChas, elem.ChelDni, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Trud_Dog

        public static List<In_Trud_Dog> GetIn_Trud_Dog()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_TRUD_DOG";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Trud_Dog> _in_trud_dog = new List<In_Trud_Dog>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_trud_dog.Add(new In_Trud_Dog()
                        {
                            Id =  Convert.ToInt32(row["ID_TRUD_DOG"]),
                            Nadbavki = row["NADB"].ToString(),
                            Oklad = row["OKLAD"].ToString(),
                            PrVyp = row["PR_VYPL"].ToString(),
                            Zp = row["ZP"].ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString()
                            }
                        }
                        );
                    }
                    return _in_trud_dog;
                }
            }
        }

        public static void DeleteIn_Trud_Dog(In_Trud_Dog elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_TRUD_DOG where ID_TRUD_DOG = {0} ", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Trud_Dog(In_Trud_Dog elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_TRUD_DOG (ID_SOTR, OKLAD, NADB, PR_VYPL) values ({0}, {1}, {2}, {3})", elem.Sotr.Id, elem.Oklad, elem.Nadbavki, elem.PrVyp);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Trud_Dog(In_Trud_Dog elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_TRUD_DOG set ID_SOTR = {0}, OKLAD = {1}, NADB = {2}, PR_VYPL = {3}  where ID_TRUD_DOG = {4} ", elem.Sotr.Id, elem.Oklad, elem.Nadbavki, elem.PrVyp, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Norm_Att

        public static List<Spr_Norm_Att> GetSpr_Norm_Att()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_SPR_NORM_ATT";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Norm_Att> _spr_norm_att = new List<Spr_Norm_Att>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_norm_att.Add(new Spr_Norm_Att()
                        {
                            Id =  Convert.ToInt32(row["ID_NORM"]),
                            Period = row["PERIOD"].ToString(),
                            Dolj = new Spr_Dolj()
                            {
                                Id =  Convert.ToInt32(row["ID_DOLJ"]),
                                Name = row["DOLJ_NAME"].ToString(),
                                Podr = new Spr_Struct_Podr()
                                {
                                    Id = Convert.ToInt32(row["ID_PODR"]),
                                    Name = row["PODR_NAME"].ToString()
                                }
                            }
                        }
                        );
                    }
                    return _spr_norm_att;
                }
            }
        }

        public static void DeleteSpr_Norm_Att(Spr_Norm_Att elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_SPR_NORM_ATT where id_norm = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSpr_Norm_Att(Spr_Norm_Att elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_SPR_NORM_ATT (ID_DOLJ, PERIOD) values ({0}, {1})", elem.Dolj.Id, elem.Period);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditSpr_Norm_Att(Spr_Norm_Att elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_NORM_ATT set ID_DOLJ = {0}, PERIOD = {1} where ID_NORM = {2}", elem.Dolj.Id, elem.Period, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Pr_Att_Komm

        public static List<In_Pr_Att_Komm> GetIn_Pr_Att_Komm()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_PR_ATT_KOMM";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Pr_Att_Komm> _in_pr_att_komm = new List<In_Pr_Att_Komm>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_pr_att_komm.Add(new In_Pr_Att_Komm()
                        {
                            Id = Convert.ToInt32(row["ID_PROT"]),
                            ProhodBall = row["MINBALL"].ToString(),
                            SummBall = row["BALL"].ToString(),
                            Date = row["DATE_ATT"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["DATE_ATT"]),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name = row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            }
                        }
                        );
                    }
                    return _in_pr_att_komm;
                }
            }
        }

        public static void DeleteIn_Pr_Att_Komm(In_Pr_Att_Komm elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_PR_ATT_KOMM where ID_PROT = {0} ", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Pr_Att_Komm(In_Pr_Att_Komm elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_PR_ATT_KOMM (ID_SOTR, BALL, MINBALL, DATE_ATT) values ({0}, {1}, {2}, to_date('{3}', 'yyyy/MM/dd'))", elem.Sotr.Id, elem.SummBall, elem.ProhodBall, elem.Date.Value.ToString("yyyy/MM/dd"));
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Pr_Att_Komm(In_Pr_Att_Komm elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_PR_ATT_KOMM set ID_SOTR = {0}, BALL = {1}, MINBALL = {2}, DATE_ATT = to_date('{4}', 'yyyy/MM/dd') where ID_PROT = {3} ", elem.Sotr.Id, elem.SummBall, elem.ProhodBall, elem.Id, elem.Date.Value.ToString("yyyy/MM/dd"));
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Spr_Ob_Den_Srv

        public static List<Spr_Ob_Den_Srv> GetSpr_Ob_Den_Srv()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM T_SPR_OB_DEN_SR";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Ob_Den_Srv> _spr_ob_den_srv = new List<Spr_Ob_Den_Srv>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_ob_den_srv.Add(new Spr_Ob_Den_Srv()
                        {
                            Summ = row["RAZM_OPL"].ToString(),
                            Year = row["YEAR"].ToString()
                        }
                        );
                    }
                    return _spr_ob_den_srv;
                }
            }
        }

        

        public static void EditSpr_Ob_Den_Srv(Spr_Ob_Den_Srv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_SPR_OB_DEN_SR set RAZM_OPL = {0}  where YEAR = {1} ", elem.Summ, elem.Year);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Zayav_Pov_Kv

        public static List<In_Zayav_Pov_Kv> GetIn_Zayav_Pov_Kv()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_ZAYAV_POV_KV";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Zayav_Pov_Kv> _in_zayav_pov_kv = new List<In_Zayav_Pov_Kv>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_zayav_pov_kv.Add(new In_Zayav_Pov_Kv()
                        {
                            Id =  Convert.ToInt32(row["ID_ZAYAV"]),
                            SRO = row["SRO"].ToString(),
                            Sotr = new Spr_Sotr()
                            {
                                Id =  Convert.ToInt32(row["ID_SOTR"]),
                                Name = row["SOTR_NAME"].ToString(),
                                Dolj = new Spr_Dolj()
                                {
                                    Name =  row["DOLJ_NAME"].ToString(),
                                    Podr = new Spr_Struct_Podr()
                                    {
                                        Name = row["PODR_NAME"].ToString()
                                    }
                                }
                            },
                            Theme = new Spr_Theme()
                            {
                                Id =  Convert.ToInt32(row["ID_THEME"]),
                                Name = row["THEME_NAME"].ToString()
                            }
                        }
                        );
                    }
                    return _in_zayav_pov_kv;
                }
            }
        }

        public static void DeleteIn_Zayav_Pov_Kv(In_Zayav_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_ZAYAV_POV_KV where ID_ZAYAV = {0} ", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Zayav_Pov_Kv(In_Zayav_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_ZAYAV_POV_KV (ID_THEME, ID_SOTR, SRO) values ({0}, {1}, '{2}')", elem.Theme.Id, elem.Sotr.Id, elem.SRO);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Zayav_Pov_Kv(In_Zayav_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_ZAYAV_POV_KV set ID_THEME = {0}, ID_SOTR = {1}, SRO = '{2}'  where ID_ZAYAV = {3} ", elem.Theme.Id, elem.Sotr.Id, elem.SRO, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region In_Prikaz_Pov_Kv

        public static List<In_Prikaz_Pov_Kv> GetIn_Prikaz_Pov_Kv()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_PRIKAZ_POV_KV";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Prikaz_Pov_Kv> _in_prikaz_pov_kv = new List<In_Prikaz_Pov_Kv>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_prikaz_pov_kv.Add(new In_Prikaz_Pov_Kv()
                        {
                            Id =  Convert.ToInt32(row["ID_PRIKAZ"]),
                            Zayav = new In_Zayav_Pov_Kv()
                            {
                                Id =  Convert.ToInt32(row["ID_ZAYAV"]),
                                Sotr = new Spr_Sotr()
                                {
                                    Id =  Convert.ToInt32(row["ID_SOTR"]),
                                    Name = row["SOTR_NAME"].ToString(),
                                    Dolj = new Spr_Dolj()
                                    {
                                        Name = row["DOLJ_NAME"].ToString(),
                                        Podr = new Spr_Struct_Podr()
                                        {
                                            Name = row["PODR_NAME"].ToString()
                                        }
                                    }
                                },
                                Theme = new Spr_Theme()
                                {
                                    Id =  Convert.ToInt32(row["ID_THEME"]),
                                    Name = row["THEME_NAME"].ToString()
                                } 
                            }
                        }
                        );
                    }
                    return _in_prikaz_pov_kv;
                }
            }
        }

        public static void DeleteIn_Prikaz_Pov_Kv(In_Prikaz_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_PRIKAZ_POV_KV where ID_PRIKAZ = {0}", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Prikaz_Pov_Kv(In_Prikaz_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_PRIKAZ_POV_KV (ID_ZAYAV) values ({0})", elem.Zayav.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Prikaz_Pov_Kv(In_Prikaz_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_PRIKAZ_POV_KV set ID_ZAYAV = {0}  where ID_PRIKAZ = {1} ", elem.Zayav.Id, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Out_An_Tek

        public static List<Out_An_Tek> GetOut_An_Tek()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_AN_TEK";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_An_Tek> _Out_An_Tek = new List<Out_An_Tek>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _Out_An_Tek.Add(new Out_An_Tek()
                        {
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Podr_Name = row["KOLVO"].ToString(),
                            SotrName = row["PODR_NAME"].ToString(),
                            ThemeName = row["PRICHINA"].ToString()
                        }
                        );
                    }
                    return _Out_An_Tek;
                }
            }
        }

        public static Out_An_Tek GetPrichina()
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT  DISTINCT prichina  FROM V_OUT_AN_TEK where kolvo =(Select max(kolvo) from V_OUT_AN_TEK)";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count > 1)
                    {
                        string str = dt.Rows[0][0].ToString();
                        for (int i = 1; i < dt.Rows.Count; i++)
                        {
                            str = String.Concat(str,"\n", dt.Rows[i][0].ToString());
                        }
                        return new Out_An_Tek()
                        {
                            ThemeName = "Самые весомые:",
                            Podr_Name = str
                        };
                    }
                    else
                    {
                        return new Out_An_Tek()
                        {
                            ThemeName = "Самая весомая:",
                            Podr_Name = dt.Rows[0][0].ToString()
                        };
                   }
                }
            }
        }
        #endregion

        #region Out_Control_Graf_Pov_Kv

        public static List<Out_Control_Graf_Pov_Kv> GetOut_Control_Graf_Pov_Kv()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_OUT_CONTROL_GRAF_POV_KV";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Out_Control_Graf_Pov_Kv> _Out_An_Tek = new List<Out_Control_Graf_Pov_Kv>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _Out_An_Tek.Add(new Out_Control_Graf_Pov_Kv()
                        {
                            Dolj_Name = row["DOLJ_NAME"].ToString(),
                            Id_Prikaz =  Convert.ToInt32(row["ID_PRIKAZ"]),
                            OrgName = row["ORG_NAME"].ToString(),
                            PlanDate = row["DATE_PROV"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["DATE_PROV"].ToString()),
                            Podr_Name = row["PODR_NAME"].ToString(),
                            SotrName = row["SOTR_NAME"].ToString(),
                            ThemeName = row["THEME_NAME"].ToString(),
                            FactDate = row["FACT_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["FACT_DATE"].ToString()), 
                            DocName = row["DOC_NAME"].ToString()
                        }
                        );
                    }
                    return _Out_An_Tek;
                }
            }
        }
        #endregion

        #region In_Svid_Pov_Kv

        public static List<In_Svid_Pov_Kv> GetIn_Svid_Pov_Kv()
        {



            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM V_IN_SVID_POV_KV";

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<In_Svid_Pov_Kv> _in_svid_pov_kv = new List<In_Svid_Pov_Kv>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _in_svid_pov_kv.Add(new In_Svid_Pov_Kv()
                        {
                            Id =  Convert.ToInt32(row["ID_SVID"]),
                            DocName = row["DOC_NAME"].ToString(),
                            FactDate = row["FACT_DATE"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["FACT_DATE"].ToString()),
                            GrafSotr = new Out_An_Tek()
                            {
                                Dolj_Name = row["DOLJ_NAME"].ToString(),
                                Id_Prikaz =  Convert.ToInt32(row["ID_PRIKAZ"]),
                                OrgName = row["ORG_NAME"].ToString(),
                                PlanDate = row["DATE_PROV"] is DBNull ? (DateTime?)null : Convert.ToDateTime(row["DATE_PROV"].ToString()),
                                Podr_Name = row["PODR_NAME"].ToString(),
                                SotrName = row["SOTR_NAME"].ToString(),
                                ThemeName = row["THEME_NAME"].ToString()
                            }
                        }
                        );
                    }
                    return _in_svid_pov_kv;
                }
            }
        }

        public static void DeleteIn_Svid_Pov_Kv(In_Svid_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("delete from T_IN_SVID_POV_KV where ID_SVID = {0} ", elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddIn_Svid_Pov_Kv(In_Svid_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("insert into T_IN_SVID_POV_KV (ID_PRIKAZ, FACT_DATE, DOC_NAME) values ({0}, to_date('{1}', 'yyyy/MM/dd'), '{2}')", elem.GrafSotr.Id_Prikaz, elem.FactDate.Value.ToString("yyyy/MM/dd"), elem.DocName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditIn_Svid_Pov_Kv(In_Svid_Pov_Kv elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("update T_IN_SVID_POV_KV set ID_PRIKAZ = {0}, FACT_DATE = to_date('{1}', 'yyyy/MM/dd'), DOC_NAME = '{2}'  where ID_SVID = {3} ", elem.GrafSotr.Id_Prikaz, elem.FactDate.Value.ToString("yyyy/MM/dd"), elem.DocName, elem.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        public static List<Spr_Dolj> GetDoljByPodr(Spr_Struct_Podr elem)
        {
            using (OracleConnection connection = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=root-PC)(Port=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));PERSIST SECURITY INFO=True;USER ID=USER;PASSWORD=boxraptor"))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT * FROM V_SPR_DOLJ where ID_PODR = {0}", elem.Id);

                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    List<Spr_Dolj> _spr_dolj = new List<Spr_Dolj>();

                    foreach (DataRow row in dt.Rows)
                    {
                        _spr_dolj.Add(new Spr_Dolj()
                        {
                            Id =  Convert.ToInt32(row["ID_DOLJ"]),
                            Name = row["DOLJ_NAME"].ToString(),
                            Podr = new Spr_Struct_Podr()
                            {
                                Id = Convert.ToInt32(row["ID_PODR"]),
                                Name = row["PODR_NAME"].ToString()
                            }
                        }
                        );
                    }
                    return _spr_dolj;
                }
            }
        }
    }
}
