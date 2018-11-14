﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SCMSEntities : DbContext
    {
        public SCMSEntities()
            : base("name=SCMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Check_Application> Check_Application { get; set; }
        public virtual DbSet<CM_Account> CM_Account { get; set; }
        public virtual DbSet<CM_AVI_Log> CM_AVI_Log { get; set; }
        public virtual DbSet<CM_Department> CM_Department { get; set; }
        public virtual DbSet<CM_Error> CM_Error { get; set; }
        public virtual DbSet<CM_FTP_Log> CM_FTP_Log { get; set; }
        public virtual DbSet<CM_Line> CM_Line { get; set; }
        public virtual DbSet<CM_Log_Machine> CM_Log_Machine { get; set; }
        public virtual DbSet<CM_Machine> CM_Machine { get; set; }
        public virtual DbSet<CM_Machine_Directory> CM_Machine_Directory { get; set; }
        public virtual DbSet<CM_Machine_DLL> CM_Machine_DLL { get; set; }
        public virtual DbSet<CM_Model> CM_Model { get; set; }
        public virtual DbSet<CM_ModelChange> CM_ModelChange { get; set; }
        public virtual DbSet<CM_Port> CM_Port { get; set; }
        public virtual DbSet<CM_Process> CM_Process { get; set; }
        public virtual DbSet<CM_Project> CM_Project { get; set; }
        public virtual DbSet<CM_Roles> CM_Roles { get; set; }
        public virtual DbSet<CM_Socket> CM_Socket { get; set; }
        public virtual DbSet<CM_Title> CM_Title { get; set; }
        public virtual DbSet<CM_Zone> CM_Zone { get; set; }
        public virtual DbSet<History_check_app> History_check_app { get; set; }
        public virtual DbSet<QM_DualCal> QM_DualCal { get; set; }
        public virtual DbSet<QM_DualCAL_Handler> QM_DualCAL_Handler { get; set; }
        public virtual DbSet<QM_FT_50cm_Tele> QM_FT_50cm_Tele { get; set; }
        public virtual DbSet<QM_FT_AF_Cal_Rangechecklog> QM_FT_AF_Cal_Rangechecklog { get; set; }
        public virtual DbSet<QM_FT_Handler> QM_FT_Handler { get; set; }
        public virtual DbSet<QM_FT_Image_RGBLog_Tele> QM_FT_Image_RGBLog_Tele { get; set; }
        public virtual DbSet<QM_FT_Image_RGBLog_Wide> QM_FT_Image_RGBLog_Wide { get; set; }
        public virtual DbSet<QM_FT_Image_Samsung_Vignettinglog_Wide> QM_FT_Image_Samsung_Vignettinglog_Wide { get; set; }
        public virtual DbSet<QM_FT_LongAF_Tele> QM_FT_LongAF_Tele { get; set; }
        public virtual DbSet<QM_FT_LongAF_Wide_B_F15> QM_FT_LongAF_Wide_B_F15 { get; set; }
        public virtual DbSet<QM_FT_LongAF_Wide_B_F24> QM_FT_LongAF_Wide_B_F24 { get; set; }
        public virtual DbSet<QM_FT_Marco_AF> QM_FT_Marco_AF { get; set; }
        public virtual DbSet<QM_HORI_Handler> QM_HORI_Handler { get; set; }
        public virtual DbSet<QM_Ois> QM_Ois { get; set; }
        public virtual DbSet<QM_Ois_Singer> QM_Ois_Singer { get; set; }
        public virtual DbSet<QM_PAF_AE_Cal_Ratio> QM_PAF_AE_Cal_Ratio { get; set; }
        public virtual DbSet<QM_PAF_Handler> QM_PAF_Handler { get; set; }
        public virtual DbSet<QM_PAF_Tele_AE_Cal_Check> QM_PAF_Tele_AE_Cal_Check { get; set; }
        public virtual DbSet<QM_PAF_Tele_AFcode_Compare> QM_PAF_Tele_AFcode_Compare { get; set; }
        public virtual DbSet<QM_PAF_Tele_Pan_AF_100cm> QM_PAF_Tele_Pan_AF_100cm { get; set; }
        public virtual DbSet<QM_PAF_Wide_AFcode_Compare> QM_PAF_Wide_AFcode_Compare { get; set; }
        public virtual DbSet<QM_PAF_Wide_Macro_AF> QM_PAF_Wide_Macro_AF { get; set; }
        public virtual DbSet<QM_PAF_Wide_Panpos> QM_PAF_Wide_Panpos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<MACHINE_QUANTITY_SCREEN> MACHINE_QUANTITY_SCREEN { get; set; }
        public virtual DbSet<QTY_OF_LINE_BY_PROCESS_ON_DATE_SCREEN> QTY_OF_LINE_BY_PROCESS_ON_DATE_SCREEN { get; set; }
        public virtual DbSet<QTY_OF_MACHINE_BY_PROCESS_ON_DATE_SCREEN> QTY_OF_MACHINE_BY_PROCESS_ON_DATE_SCREEN { get; set; }
        public virtual DbSet<V_LAST_EXECUTE> V_LAST_EXECUTE { get; set; }
        public virtual DbSet<v_LINE_MODEL> v_LINE_MODEL { get; set; }
        public virtual DbSet<V_MACHINE_STATUS> V_MACHINE_STATUS { get; set; }
        public virtual DbSet<V_Machines> V_Machines { get; set; }
        public virtual DbSet<V_TABLESIZE> V_TABLESIZE { get; set; }
        public virtual DbSet<V_TABLESIZE2> V_TABLESIZE2 { get; set; }
        public virtual DbSet<V_TESTRESULTDETAIL> V_TESTRESULTDETAIL { get; set; }
        public virtual DbSet<V_TESTRESULTINPUT> V_TESTRESULTINPUT { get; set; }
        public virtual DbSet<V_TESTRESULTNG> V_TESTRESULTNG { get; set; }
        public virtual DbSet<V_TESTRESULTOK> V_TESTRESULTOK { get; set; }
        public virtual DbSet<V_TESTRESULTOTHERPROCESS> V_TESTRESULTOTHERPROCESS { get; set; }
        public virtual DbSet<YIELD_RATE_BY_LINE_SCREEN> YIELD_RATE_BY_LINE_SCREEN { get; set; }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER")]
        public virtual IQueryable<GET_FTP_LOGGER_Result> GET_FTP_LOGGER(Nullable<int> mODEL, Nullable<int> iNSPECTION)
        {
            var mODELParameter = mODEL.HasValue ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(int));
    
            var iNSPECTIONParameter = iNSPECTION.HasValue ?
                new ObjectParameter("INSPECTION", iNSPECTION) :
                new ObjectParameter("INSPECTION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_Result>("[SCMSEntities].[GET_FTP_LOGGER](@MODEL, @INSPECTION)", mODELParameter, iNSPECTIONParameter);
        }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER_FILE")]
        public virtual IQueryable<GET_FTP_LOGGER_FILE_Result> GET_FTP_LOGGER_FILE(Nullable<int> lINE)
        {
            var lINEParameter = lINE.HasValue ?
                new ObjectParameter("LINE", lINE) :
                new ObjectParameter("LINE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_FILE_Result>("[SCMSEntities].[GET_FTP_LOGGER_FILE](@LINE)", lINEParameter);
        }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER_HOURLY_HUY")]
        public virtual IQueryable<GET_FTP_LOGGER_HOURLY_HUY_Result> GET_FTP_LOGGER_HOURLY_HUY(string mODEL, string iNSPECTION)
        {
            var mODELParameter = mODEL != null ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(string));
    
            var iNSPECTIONParameter = iNSPECTION != null ?
                new ObjectParameter("INSPECTION", iNSPECTION) :
                new ObjectParameter("INSPECTION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_HOURLY_HUY_Result>("[SCMSEntities].[GET_FTP_LOGGER_HOURLY_HUY](@MODEL, @INSPECTION)", mODELParameter, iNSPECTIONParameter);
        }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER_HOURLY_HUY1")]
        public virtual IQueryable<GET_FTP_LOGGER_HOURLY_HUY1_Result> GET_FTP_LOGGER_HOURLY_HUY1(string mODEL, string iNSPECTION)
        {
            var mODELParameter = mODEL != null ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(string));
    
            var iNSPECTIONParameter = iNSPECTION != null ?
                new ObjectParameter("INSPECTION", iNSPECTION) :
                new ObjectParameter("INSPECTION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_HOURLY_HUY1_Result>("[SCMSEntities].[GET_FTP_LOGGER_HOURLY_HUY1](@MODEL, @INSPECTION)", mODELParameter, iNSPECTIONParameter);
        }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER_HOURLY_SI")]
        public virtual IQueryable<GET_FTP_LOGGER_HOURLY_SI_Result> GET_FTP_LOGGER_HOURLY_SI(string mODEL, string iNSPECTION)
        {
            var mODELParameter = mODEL != null ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(string));
    
            var iNSPECTIONParameter = iNSPECTION != null ?
                new ObjectParameter("INSPECTION", iNSPECTION) :
                new ObjectParameter("INSPECTION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_HOURLY_SI_Result>("[SCMSEntities].[GET_FTP_LOGGER_HOURLY_SI](@MODEL, @INSPECTION)", mODELParameter, iNSPECTIONParameter);
        }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER_HOURLY_SI1")]
        public virtual IQueryable<GET_FTP_LOGGER_HOURLY_SI1_Result> GET_FTP_LOGGER_HOURLY_SI1(string mODEL, string iNSPECTION)
        {
            var mODELParameter = mODEL != null ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(string));
    
            var iNSPECTIONParameter = iNSPECTION != null ?
                new ObjectParameter("INSPECTION", iNSPECTION) :
                new ObjectParameter("INSPECTION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_HOURLY_SI1_Result>("[SCMSEntities].[GET_FTP_LOGGER_HOURLY_SI1](@MODEL, @INSPECTION)", mODELParameter, iNSPECTIONParameter);
        }
    
        [DbFunction("SCMSEntities", "GET_FTP_LOGGER_Si")]
        public virtual IQueryable<GET_FTP_LOGGER_Si_Result> GET_FTP_LOGGER_Si(Nullable<int> mODEL, Nullable<int> iNSPECTION)
        {
            var mODELParameter = mODEL.HasValue ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(int));
    
            var iNSPECTIONParameter = iNSPECTION.HasValue ?
                new ObjectParameter("INSPECTION", iNSPECTION) :
                new ObjectParameter("INSPECTION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GET_FTP_LOGGER_Si_Result>("[SCMSEntities].[GET_FTP_LOGGER_Si](@MODEL, @INSPECTION)", mODELParameter, iNSPECTIONParameter);
        }
    
        [DbFunction("SCMSEntities", "getDailyQty")]
        public virtual IQueryable<getDailyQty_Result> getDailyQty(Nullable<System.DateTime> date, Nullable<int> model)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var modelParameter = model.HasValue ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getDailyQty_Result>("[SCMSEntities].[getDailyQty](@date, @model)", dateParameter, modelParameter);
        }
    
        [DbFunction("SCMSEntities", "getDailyQty_PCT")]
        public virtual IQueryable<getDailyQty_PCT_Result> getDailyQty_PCT(Nullable<System.DateTime> date, Nullable<int> model, string process)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var modelParameter = model.HasValue ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(int));
    
            var processParameter = process != null ?
                new ObjectParameter("process", process) :
                new ObjectParameter("process", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getDailyQty_PCT_Result>("[SCMSEntities].[getDailyQty_PCT](@date, @model, @process)", dateParameter, modelParameter, processParameter);
        }
    
        [DbFunction("SCMSEntities", "getDailyQty1")]
        public virtual IQueryable<getDailyQty1_Result> getDailyQty1(Nullable<int> model)
        {
            var modelParameter = model.HasValue ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getDailyQty1_Result>("[SCMSEntities].[getDailyQty1](@model)", modelParameter);
        }
    
        [DbFunction("SCMSEntities", "getDailyQty2")]
        public virtual IQueryable<getDailyQty2_Result> getDailyQty2(Nullable<int> model)
        {
            var modelParameter = model.HasValue ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getDailyQty2_Result>("[SCMSEntities].[getDailyQty2](@model)", modelParameter);
        }
    
        public virtual ObjectResult<CheckOKNGQuantity_Result> CheckOKNGQuantity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CheckOKNGQuantity_Result>("CheckOKNGQuantity");
        }
    
        public virtual ObjectResult<CheckQuantityDaily_Result> CheckQuantityDaily()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CheckQuantityDaily_Result>("CheckQuantityDaily");
        }
    
        public virtual int ftp_log(string ip, string ftp_error, string error_detail, Nullable<int> row)
        {
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            var ftp_errorParameter = ftp_error != null ?
                new ObjectParameter("ftp_error", ftp_error) :
                new ObjectParameter("ftp_error", typeof(string));
    
            var error_detailParameter = error_detail != null ?
                new ObjectParameter("error_detail", error_detail) :
                new ObjectParameter("error_detail", typeof(string));
    
            var rowParameter = row.HasValue ?
                new ObjectParameter("row", row) :
                new ObjectParameter("row", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ftp_log", ipParameter, ftp_errorParameter, error_detailParameter, rowParameter);
        }
    
        public virtual ObjectResult<Get_List_Status_Day_Result> Get_List_Status_Day(string status, Nullable<System.DateTime> start, Nullable<System.DateTime> stop)
        {
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(System.DateTime));
    
            var stopParameter = stop.HasValue ?
                new ObjectParameter("stop", stop) :
                new ObjectParameter("stop", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_List_Status_Day_Result>("Get_List_Status_Day", statusParameter, startParameter, stopParameter);
        }
    
        public virtual ObjectResult<Get_List_Status_Day_Hour_Total_Result> Get_List_Status_Day_Hour_Total(Nullable<System.DateTime> start, Nullable<System.DateTime> stop)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(System.DateTime));
    
            var stopParameter = stop.HasValue ?
                new ObjectParameter("stop", stop) :
                new ObjectParameter("stop", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_List_Status_Day_Hour_Total_Result>("Get_List_Status_Day_Hour_Total", startParameter, stopParameter);
        }
    
        public virtual ObjectResult<GET_NOOFMCSTATUS_Result> GET_NOOFMCSTATUS(string mODEL)
        {
            var mODELParameter = mODEL != null ?
                new ObjectParameter("MODEL", mODEL) :
                new ObjectParameter("MODEL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_NOOFMCSTATUS_Result>("GET_NOOFMCSTATUS", mODELParameter);
        }
    
        public virtual ObjectResult<GetAllDataModel_Result> GetAllDataModel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllDataModel_Result>("GetAllDataModel");
        }
    
        public virtual ObjectResult<getDailyQtyOIS_Result> getDailyQtyOIS(Nullable<int> modelID)
        {
            var modelIDParameter = modelID.HasValue ?
                new ObjectParameter("modelID", modelID) :
                new ObjectParameter("modelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDailyQtyOIS_Result>("getDailyQtyOIS", modelIDParameter);
        }
    
        public virtual ObjectResult<GetDataLineModel_Result> GetDataLineModel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDataLineModel_Result>("GetDataLineModel");
        }
    
        public virtual ObjectResult<string> GetProcessLine(string linename)
        {
            var linenameParameter = linename != null ?
                new ObjectParameter("linename", linename) :
                new ObjectParameter("linename", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetProcessLine", linenameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetTotalDailyOIS(Nullable<int> model, Nullable<System.DateTime> date)
        {
            var modelParameter = model.HasValue ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetTotalDailyOIS", modelParameter, dateParameter);
        }
    
        public virtual ObjectResult<GETTOTALQTY_OIS_Result> GETTOTALQTY_OIS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETTOTALQTY_OIS_Result>("GETTOTALQTY_OIS");
        }
    
        public virtual ObjectResult<Nullable<int>> GETTOTALQTYINPUT(Nullable<int> mODELID)
        {
            var mODELIDParameter = mODELID.HasValue ?
                new ObjectParameter("MODELID", mODELID) :
                new ObjectParameter("MODELID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GETTOTALQTYINPUT", mODELIDParameter);
        }
    
        public virtual int Machine_Connect(string ip)
        {
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Machine_Connect", ipParameter);
        }
    
        public virtual int Machine_Disconnect(string ip)
        {
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Machine_Disconnect", ipParameter);
        }
    
        public virtual int Proc_Create_CM_Account(string gEN, string fullname, string pass, string email)
        {
            var gENParameter = gEN != null ?
                new ObjectParameter("GEN", gEN) :
                new ObjectParameter("GEN", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_Create_CM_Account", gENParameter, fullnameParameter, passParameter, emailParameter);
        }
    
        public virtual ObjectResult<Proc_Find_CM_Account_Result> Proc_Find_CM_Account(string gEN)
        {
            var gENParameter = gEN != null ?
                new ObjectParameter("GEN", gEN) :
                new ObjectParameter("GEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_Find_CM_Account_Result>("Proc_Find_CM_Account", gENParameter);
        }
    
        public virtual ObjectResult<string> Proc_Find_LineModel(string model)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Proc_Find_LineModel", modelParameter);
        }
    
        public virtual ObjectResult<string> Proc_Find_LineZone(string zone)
        {
            var zoneParameter = zone != null ?
                new ObjectParameter("zone", zone) :
                new ObjectParameter("zone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Proc_Find_LineZone", zoneParameter);
        }
    
        public virtual ObjectResult<Proc_FindAll_CM_Line_Result> Proc_FindAll_CM_Line()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_FindAll_CM_Line_Result>("Proc_FindAll_CM_Line");
        }
    
        public virtual ObjectResult<Proc_FindAll_CM_Machine_Result> Proc_FindAll_CM_Machine()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_FindAll_CM_Machine_Result>("Proc_FindAll_CM_Machine");
        }
    
        public virtual ObjectResult<Proc_FindAll_CM_Model_Result> Proc_FindAll_CM_Model()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_FindAll_CM_Model_Result>("Proc_FindAll_CM_Model");
        }
    
        public virtual ObjectResult<Proc_FindAll_CM_Process_Result> Proc_FindAll_CM_Process()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_FindAll_CM_Process_Result>("Proc_FindAll_CM_Process");
        }
    
        public virtual ObjectResult<Proc_FindAll_CM_Zone_Result> Proc_FindAll_CM_Zone()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_FindAll_CM_Zone_Result>("Proc_FindAll_CM_Zone");
        }
    
        public virtual ObjectResult<Proc_FindUser_CM_Account_Result> Proc_FindUser_CM_Account(string username, string pass)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_FindUser_CM_Account_Result>("Proc_FindUser_CM_Account", usernameParameter, passParameter);
        }
    
        public virtual ObjectResult<PROC_GETNOOFMCMODEL_Result> PROC_GETNOOFMCMODEL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_GETNOOFMCMODEL_Result>("PROC_GETNOOFMCMODEL");
        }
    
        public virtual ObjectResult<PROC_GETNOOFMCMODELSTATUS_Result> PROC_GETNOOFMCMODELSTATUS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_GETNOOFMCMODELSTATUS_Result>("PROC_GETNOOFMCMODELSTATUS");
        }
    
        public virtual ObjectResult<PROC_GETQTYDAILYHOUR_Result> PROC_GETQTYDAILYHOUR(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_GETQTYDAILYHOUR_Result>("PROC_GETQTYDAILYHOUR", dATEParameter);
        }
    
        public virtual ObjectResult<PROC_GETQTYDAILYHOUR_SINGLE_Result> PROC_GETQTYDAILYHOUR_SINGLE(Nullable<System.DateTime> dATE)
        {
            var dATEParameter = dATE.HasValue ?
                new ObjectParameter("DATE", dATE) :
                new ObjectParameter("DATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_GETQTYDAILYHOUR_SINGLE_Result>("PROC_GETQTYDAILYHOUR_SINGLE", dATEParameter);
        }
    
        public virtual ObjectResult<Proc_Machines_Result> Proc_Machines()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_Machines_Result>("Proc_Machines");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<SP_MODEL_QTY_Result> SP_MODEL_QTY(Nullable<System.DateTime> date, string model)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_MODEL_QTY_Result>("SP_MODEL_QTY", dateParameter, modelParameter);
        }
    
        public virtual ObjectResult<SP_MODEL_QTY_7_DAYS_AGO_Result> SP_MODEL_QTY_7_DAYS_AGO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_MODEL_QTY_7_DAYS_AGO_Result>("SP_MODEL_QTY_7_DAYS_AGO");
        }
    
        public virtual ObjectResult<string> SP_MODULE_CHECKING(string module)
        {
            var moduleParameter = module != null ?
                new ObjectParameter("module", module) :
                new ObjectParameter("module", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_MODULE_CHECKING", moduleParameter);
        }
    
        public virtual ObjectResult<SP_PROCESS_QTY_7_DAYS_AGO_Result> SP_PROCESS_QTY_7_DAYS_AGO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PROCESS_QTY_7_DAYS_AGO_Result>("SP_PROCESS_QTY_7_DAYS_AGO");
        }
    
        public virtual ObjectResult<SP_PROCESS_QTY_HOURLY_Result> SP_PROCESS_QTY_HOURLY(Nullable<System.DateTime> date, string process, Nullable<int> line)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var processParameter = process != null ?
                new ObjectParameter("process", process) :
                new ObjectParameter("process", typeof(string));
    
            var lineParameter = line.HasValue ?
                new ObjectParameter("line", line) :
                new ObjectParameter("line", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PROCESS_QTY_HOURLY_Result>("SP_PROCESS_QTY_HOURLY", dateParameter, processParameter, lineParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<SP_TACKTIME_SITE_Result> SP_TACKTIME_SITE(Nullable<System.DateTime> date, string process)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var processParameter = process != null ?
                new ObjectParameter("process", process) :
                new ObjectParameter("process", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TACKTIME_SITE_Result>("SP_TACKTIME_SITE", dateParameter, processParameter);
        }
    
        public virtual ObjectResult<SP_TOP_ERROR_Result> SP_TOP_ERROR(Nullable<System.DateTime> date, string process, Nullable<int> model)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var processParameter = process != null ?
                new ObjectParameter("process", process) :
                new ObjectParameter("process", typeof(string));
    
            var modelParameter = model.HasValue ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TOP_ERROR_Result>("SP_TOP_ERROR", dateParameter, processParameter, modelParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdateMachine(string ip, Nullable<int> status)
        {
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMachine", ipParameter, statusParameter);
        }
    }
}