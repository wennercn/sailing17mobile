using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using ATLDATALib;

namespace sailing17Mobile
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Reflection;
    using ATLDATALib;

    public class _RPC
    {
        public _RPC()
        {
            _loaderType = Type.GetTypeFromCLSID(new Guid("{45DD3EDD-0E5F-40a7-BECF-672AEFF0E293}"));
            _loaderInstance = System.Activator.CreateInstance(_loaderType);
            ShipPlanControl = new _ShipPlanControl(this);
            CodePropertyControl = new _CodePropertyControl(this);
            LocationControl = new _LocationControl(this);
            EmployeeControl = new _EmployeeControl(this);
            ShipBoxPriceControl = new _ShipBoxPriceControl(this);
            Privilege = new _Privilege(this);
            MessageControl = new _MessageControl(this);
            EmployeePropertyControl = new _EmployeePropertyControl(this);
            ProductPropertyControl = new _ProductPropertyControl(this);
            StartStandControl = new _StartStandControl(this);
            ShipControl = new _ShipControl(this);
            RoleFunctionControl = new _RoleFunctionControl(this);
            ProductControl = new _ProductControl(this);
            JobPropertyControl = new _JobPropertyControl(this);
            ProcessControl = new _ProcessControl(this);
            ShipChangeControl = new _ShipChangeControl(this);
            LocationPropertyControl = new _LocationPropertyControl(this);
            CodeCodeControl = new _CodeCodeControl(this);
            SQLServer = new _SQLServer(this);
        }

        public void SetSession(params object[] args)
        {
            _loaderType.InvokeMember("SetSession", BindingFlags.InvokeMethod | BindingFlags.Public, null, _loaderInstance, args);
        }
        public class _SQLServer
        {
            public _SQLServer(_RPC rt)
            {
                root = rt;

            }
            public IDBDataAtl BeginWork(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SQLServer.BeginWork()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Select(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SQLServer.Select()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Execute(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SQLServer.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Rollback(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SQLServer.Rollback()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Commit(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SQLServer.Commit()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            protected _RPC root;

        }
        public class _ShipPlanControl
        {
            public _ShipPlanControl(_RPC rt)
            {
                root = rt;
                ShipPlan = new _ShipPlan(rt);
            }

            public IDBDataAtl CreateTaskList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.CreateTaskList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanShipForRoleList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetPlanShipForRoleList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadProcess(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanOtdList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetPlanOtdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipsNews(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetShipsNews()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteShipNews(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.WriteShipNews()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanRoleList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetPlanRoleList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateChangeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateChangeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetModifyShippingCompany(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetModifyShippingCompany()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMailHstyBodyList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetMailHstyBodyList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.AddShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendSimInfo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.SendSimInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetModifyVoyage(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetModifyVoyage()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMailHstyList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetMailHstyList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ExportToSQLNew(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ExportToSQLNew()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetModifyShip(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetModifyShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ExportToSQL(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ExportToSQL()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetModifyContainer(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetModifyContainer()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipPlan(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.AddShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl TestCreate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.TestCreate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetModifyPort(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetModifyPort()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ASToSQL(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ASToSQL()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _ShipPlan
            {
                public _ShipPlan(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipPlan(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipPlanProcess(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateShipPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _ShipPlan ShipPlan;
        }

        public class _CodePropertyControl
        {
            public _CodePropertyControl(_RPC rt)
            {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property
            {
                public _Property(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _LocationControl
        {
            public _LocationControl(_RPC rt)
            {
                root = rt;
                Location = new _Location(rt);
            }

            public IDBDataAtl GetLocTreeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetLocTreeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPortBerthList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetPortBerthList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCodePortList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetCodePortList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCargoNameList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetCargoNameList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipTypeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetShipTypeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCrmClientList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetCrmClientList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCargoKindList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetCargoKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddLocationList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.AddLocationList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNullData(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetNullData()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipTypeList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetShipTypeList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ReturnLocEmptyItems(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.ReturnLocEmptyItems()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelLine(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.DelLine()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelLinePort(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.DelLinePort()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUseTypeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetUseTypeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetVoyageLine(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetVoyageLine()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLocByPrevId(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetLocByPrevId()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipPurposeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetShipPurposeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetBerthList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetBerthList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveVoyageLine(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.SaveVoyageLine()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddLocation(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.AddLocation()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipTradeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetShipTradeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetVoyagePortlist(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetVoyagePortlist()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLocList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetLocList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCrmRelPersonList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetCrmRelPersonList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCodeCountryList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetCodeCountryList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Location
            {
                public _Location(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl MoveEmployee(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.MoveEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddEmployee(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.AddEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteLoc(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.DeleteLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetEmployeeList(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.GetEmployeeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateLoc(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.UpdateLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveEmployee(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.RemoveEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteLoc(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.PureDeleteLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Location Location;
        }

        public class _EmployeeControl
        {
            public _EmployeeControl(_RPC rt)
            {
                root = rt;
                Employee = new _Employee(rt);
            }

            public IDBDataAtl UpdatePass(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.UpdatePass()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateExecReason(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.UpdateExecReason()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPrivilegeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetPrivilegeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetKPAStateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetKPAStateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWatchSpare(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetWatchSpare()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateEmpRoleList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.UpdateEmpRoleList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl SendConfirm(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.SendConfirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl WriteWatchScore(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.WriteWatchScore()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadPrivilege(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.LoadPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoginForType(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.LoginForType()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddEmpTemplateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.AddEmpTemplateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteExecDetail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.DeleteExecDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWatchImport(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetWatchImport()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ActiveAccount(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.ActiveAccount()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveSingleShipDF(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.SaveSingleShipDF()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteWatchFact(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.WriteWatchFact()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddEmployee(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.AddEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddEmployeeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.AddEmployeeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSingleShipEx(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetSingleShipEx()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetRelPersonList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetRelPersonList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLocEmpInfo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetLocEmpInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CheckMail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.CheckMail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSingleShipDF(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetSingleShipDF()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetEmpList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetEmpList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendMail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.SendMail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetImportFinishList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetImportFinishList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetEmpTemplateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetEmpTemplateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWatchFactItemsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetWatchFactItemsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePassWord(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.UpdatePassWord()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendMailGui(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.SendMailGui()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateExecDoWith(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.UpdateExecDoWith()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddAccount(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.AddAccount()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetFieldInput(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetFieldInput()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetImportStateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetImportStateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetExecAllList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetExecAllList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWatchFactList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetWatchFactList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWatchDuyt(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetWatchDuyt()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Employee
            {
                public _Employee(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl GetRole(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.GetRole()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadMore(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.LoadMore()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl CheckPrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.CheckPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDelete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.PureDelete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveLocation(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.RemoveLocation()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Login(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Login()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveRole(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.RemoveRole()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Logout(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Logout()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetLocationList(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.GetLocationList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemovePrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.RemovePrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateKey(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.UpdateKey()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl CheckPassword(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.CheckPassword()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddLocation(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddLocation()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetPrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.GetPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddTrainEmp(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddTrainEmp()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddRole(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddRole()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Employee Employee;
        }

        public class _ShipBoxPriceControl
        {
            public _ShipBoxPriceControl(_RPC rt)
            {
                root = rt;
                ShipBoxPrice = new _ShipBoxPrice(rt);
            }

            public IDBDataAtl UpLoadPriceData(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpLoadPriceData()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPackDescList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetPackDescList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPortList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetPortList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateRelCode(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateRelCode()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl UpdateLoadFile(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateLoadFile()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl DelLoadFile(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelLoadFile()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipCompanyList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetShipCompanyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipBoxPrice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.AddShipBoxPrice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetKnowsOne(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetKnowsOne()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetGoodsLoadList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetGoodsLoadList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLoadBoxItemsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetLoadBoxItemsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAs400List(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetAs400List()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAgentList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetAgentList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendEDIForWebservice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendEDIForWebservice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendEDI3ForWebservice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendEDI3ForWebservice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteSailBoxNewTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteSailBoxNewTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteLoadBoxLog(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteLoadBoxLog()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UploadFileSailBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UploadFileSailBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSailCargoList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetSailCargoList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelAs400(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelAs400()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetRelCodeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetRelCodeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipOwerPortList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetShipOwerPortList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpLoadPriceList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpLoadPriceList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDeclarCustomItemsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetDeclarCustomItemsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDeclarCustomList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetDeclarCustomList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCargoCodeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetCargoCodeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnPortList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetUnPortList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UnDelSailBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UnDelSailBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetJobNo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetJobNo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTenderDetailList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetTenderDetailList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateLoadStatus(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateLoadStatus()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateShipBoxPriceList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateShipBoxPriceList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendDelEDIForWebservice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendDelEDIForWebservice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendNewEDIForWebservice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendNewEDIForWebservice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSailCargoListTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetSailCargoListTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteTenderDetail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteTenderDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNewsOne(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetNewsOne()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveUnPortList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SaveUnPortList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendNewUpdateEDIForWebservice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendNewUpdateEDIForWebservice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetKnowsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetKnowsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateDeclarStatus(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateDeclarStatus()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateDeclarCustom(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateDeclarCustom()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteDeclarCustom(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteDeclarCustom()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetClientForRoleList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetClientForRoleList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipBoxPriceList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetShipBoxPriceList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNewsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetNewsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateSailBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateSailBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateAs400(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateAs400()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSailBoxList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetSailBoxList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateSailBoxNewTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateSailBoxNewTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteShipMemo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteShipMemo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelNewsOne(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelNewsOne()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteNews(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteNews()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendMail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendMail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteGoodsLoad(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteGoodsLoad()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CheckSailBoxCol(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.CheckSailBoxCol()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelSailBoxTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelSailBoxTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSailBoxListTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetSailBoxListTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelKnowsOne(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelKnowsOne()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLoadBoxList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetLoadBoxList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteLoadBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteLoadBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateSailBoxNew(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateSailBoxNew()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipOwerList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetShipOwerList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelRelCodeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelRelCodeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipBoxPriceList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.AddShipBoxPriceList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CopyFileFF(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.CopyFileFF()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipMemo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetShipMemo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMyTenderList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetMyTenderList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelLoadBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelLoadBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateBoxStatus(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.UpdateBoxStatus()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteSailBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteSailBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendUpdateEDIForWebservice(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.SendUpdateEDIForWebservice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CheckPortDC(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.CheckPortDC()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipPriceDateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetShipPriceDateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetGUIID(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetGUIID()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteKnows(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteKnows()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSailBoxFileList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.GetSailBoxFileList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteSailBoxNew(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.WriteSailBoxNew()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelSailBox(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.DelSailBox()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _ShipBoxPrice
            {
                public _ShipBoxPrice(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl DeleteShipBoxPrice(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.ShipBoxPrice.DeleteShipBoxPrice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.ShipBoxPrice.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipBoxPrice(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipBoxPriceControl.ShipBoxPrice.UpdateShipBoxPrice()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _ShipBoxPrice ShipBoxPrice;
        }

        public class _Privilege
        {
            public _Privilege(_RPC rt)
            {
                root = rt;
                Product = new _Product(rt);
            }

            public IDBDataAtl GetAcidentProd(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DeleteCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdatePressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelProdTemplete(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DelProdTemplete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPipeCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetPipeCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProdRepList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddProdRepList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentMach(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdTemplete(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdTemplete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdRunList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdRunList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdateCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPipCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdRepList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdRepList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachFactory(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetMachFactory()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddWeekProdKeep(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddWeekProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPipCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DelPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdKeepList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdKeepList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachDep(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetMachDep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdXYList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdXYList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProduct(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddProduct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProdTempleteList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddProdTempleteList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ImpMachToDB(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.ImpMachToDB()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProductList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddProductList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKindList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdateCrmKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DelPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePipCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdatePipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Product
            {
                public _Product(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl AddProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPressCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdRun(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddProdRun()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPipeCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateLocProdHsty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateLocProdHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPipeCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadLocProdHsty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.LoadLocProdHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.LoadProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentMach(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePressCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdatePressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelLocProdHsty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelLocProdHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.LoadProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddProdCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentMach(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.PureDeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPressCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePipeCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdatePipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.LoadProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentMach(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Product Product;
        }

        public class _MessageControl
        {
            public _MessageControl(_RPC rt)
            {
                root = rt;
                Message = new _Message(rt);
            }

            public IDBDataAtl GetMessageStatusList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.GetMessageStatusList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddMessage(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.AddMessage()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUserMessageList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.GetUserMessageList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMessageUnreadList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.GetMessageUnreadList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Message
            {
                public _Message(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl MarkMessageReaden(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.MarkMessageReaden()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Message Message;
        }

        public class _EmployeePropertyControl
        {
            public _EmployeePropertyControl(_RPC rt)
            {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property
            {
                public _Property(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _ProductPropertyControl
        {
            public _ProductPropertyControl(_RPC rt)
            {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property
            {
                public _Property(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _StartStandControl
        {
            public _StartStandControl(_RPC rt)
            {
                root = rt;
                StartStand = new _StartStand(rt);
            }

            public IDBDataAtl GetMarkPlanStar(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetMarkPlanStar()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl YWYConfirmClose(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.YWYConfirmClose()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddStartStand(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.AddStartStand()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStartStandList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetStartStandList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDSList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetDSList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePlanStarTemplatePx(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.UpdatePlanStarTemplatePx()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelShipStarList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.DelShipStarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveShipStarList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.SaveShipStarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanStarTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetPlanStarTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelStartTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.DelStartTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipStarStatus(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetShipStarStatus()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStartTemplateItemsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetStartTemplateItemsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStartTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetStartTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveConfirmHstyList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.SaveConfirmHstyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipStarList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetShipStarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipStarList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetShipStarList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ConfirmDS(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.ConfirmDS()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteMarkPlanStar(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.WriteMarkPlanStar()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStarShipPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetStarShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAddMarkList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetAddMarkList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipStarTreeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetShipStarTreeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetScoreForDep(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetScoreForDep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteShipStarList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.WriteShipStarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipHstyStarList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetShipHstyStarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveStartTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.SaveStartTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStartTreeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.GetStartTreeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddStartStandList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.AddStartStandList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePlanStarTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.UpdatePlanStarTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _StartStand
            {
                public _StartStand(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.StartStand.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateStart(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.StartStand.UpdateStart()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteStart(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.StartStand.DeleteStart()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteStart(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StartStandControl.StartStand.PureDeleteStart()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _StartStand StartStand;
        }

        public class _ShipControl
        {
            public _ShipControl(_RPC rt)
            {
                root = rt;
                Ship = new _Ship(rt);
            }

            public IDBDataAtl AddShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.AddShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipTempList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetShipTempList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipsNameList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetShipsNameList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCheckShips(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetCheckShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShip(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.AddShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl PushShip(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.PushShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipsList2(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetShipsList2()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl PushShipNew(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.PushShipNew()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipsList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetShipsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentShips(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Ship
            {
                public _Ship(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl PureDeleteShips(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.PureDeleteShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentShips(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.UpdateAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShips(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.UpdateShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentShips(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.AddAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteShips(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.DeleteShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentShips(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.DelAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Ship Ship;
        }

        public class _RoleFunctionControl
        {
            public _RoleFunctionControl(_RPC rt)
            {
                root = rt;
                RoleFunction = new _RoleFunction(rt);
            }

            public IDBDataAtl GetRoleFunctionList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.GetRoleFunctionList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddRoleFunction(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.AddRoleFunction()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _RoleFunction
            {
                public _RoleFunction(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl GetPrivilegeList(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.GetPrivilegeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetRoleFunctionList(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.GetRoleFunctionList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadPrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.LoadPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemovePrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.RemovePrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveRoleFunction(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.RemoveRoleFunction()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPrivilege(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.AddPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddRoleFunction(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.AddRoleFunction()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _RoleFunction RoleFunction;
        }

        public class _ProductControl
        {
            public _ProductControl(_RPC rt)
            {
                root = rt;
                Product = new _Product(rt);
            }

            public IDBDataAtl GetAcidentProd(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DeleteCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdatePressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelProdTemplete(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DelProdTemplete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPipeCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetPipeCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProdRepList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddProdRepList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentMach(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdTemplete(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdTemplete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdRunList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdRunList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdateCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPipCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdRepList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdRepList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCrmKind(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachFactory(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetMachFactory()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddWeekProdKeep(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddWeekProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPipCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DelPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdKeepList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdKeepList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachDep(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetMachDep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdXYList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdXYList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProduct(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddProduct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProdTempleteList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddProdTempleteList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ImpMachToDB(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.ImpMachToDB()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProductList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddProductList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKindList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdateCrmKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPressCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DelPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePipCheckList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdatePipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Product
            {
                public _Product(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl AddProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPressCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdRun(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddProdRun()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPipeCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateLocProdHsty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateLocProdHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPipeCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadLocProdHsty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.LoadLocProdHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.LoadProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentMach(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePressCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdatePressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelLocProdHsty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelLocProdHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.LoadProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddProdCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProdKeep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddProdKeep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentMach(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelProdRep(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelProdRep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.PureDeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentProd(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPressCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePipeCheck(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdatePipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProdXY(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.LoadProdXY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentMach(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Product Product;
        }

        public class _JobPropertyControl
        {
            public _JobPropertyControl(_RPC rt)
            {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property
            {
                public _Property(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _ProcessControl
        {
            public _ProcessControl(_RPC rt)
            {
                root = rt;
                Process = new _Process(rt);
            }

            public IDBDataAtl GetCashList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetCashList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnAccurateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetUnAccurateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateShipPort(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateShipPort()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProcessList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetProcessList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePriTemplate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdatePriTemplate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateStartNums(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdateStartNums()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WritePlanMemo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WritePlanMemo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl ExecuteJS(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.ExecuteJS()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl GetShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCashList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetCashList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WorkRecorderSave(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WorkRecorderSave()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTempList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetTempList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreatePlanEmpList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreatePlanEmpList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetFirstList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetFirstList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateDynamic(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdateDynamic()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteShipNewPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteShipNewPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWorkPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetWorkPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTaskPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetTaskPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl onPlanChange(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.onPlanChange()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelStartTemplateItems(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.DelStartTemplateItems()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetEmpByLocName(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetEmpByLocName()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSWWatchList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetSWWatchList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WritePlanActList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WritePlanActList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreatePlanRelatePerson(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreatePlanRelatePerson()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnCompleteTask(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetUnCompleteTask()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLinePreItemList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetLinePreItemList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetFiveShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetFiveShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadPlanProcItems(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.LoadPlanProcItems()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl TaskStepCreate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.TaskStepCreate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAllFunPriList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetAllFunPriList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetRunShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetRunShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipPort(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetShipPort()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDynamicShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetDynamicShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl BGLoadTaskDetail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.BGLoadTaskDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ExuteJS(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.ExuteJS()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ReturnLocEmptyItems(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.ReturnLocEmptyItems()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnWatchList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetUnWatchList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteShipWrong(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteShipWrong()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteForceApp(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteForceApp()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveLinePreDayShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SaveLinePreDayShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateDoubleDetail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateDoubleDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDayReport(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetDayReport()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateDayReport(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateDayReport()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProcList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetProcList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelSerLine(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.DelSerLine()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteWatchFact(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteWatchFact()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WiteTemplateShipPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WiteTemplateShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteWatchFactWait(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteWatchFactWait()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipAgent(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetShipAgent()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateShipAgent(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateShipAgent()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDyReason(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetDyReason()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateDayProcess(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateDayProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveTaskList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SaveTaskList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetShipList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl onPlanChange1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.onPlanChange1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPriTreeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPriTreeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAccurateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetAccurateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSurondMoneyList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetSurondMoneyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnAllAccurateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetUnAllAccurateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipLeafList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetShipLeafList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanRelatePerson(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPlanRelatePerson()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDynamicList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetDynamicList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveDyReason(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SaveDyReason()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl BLoadTaskDetail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.BLoadTaskDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateShipProcess(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateShipProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProcState(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetProcState()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProcItemList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetProcItemList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCwAlertShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetCwAlertShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanMemoList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPlanMemoList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ForceSub(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.ForceSub()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetRunStatList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetRunStatList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNewPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetNewPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SavePlanPreDayShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SavePlanPreDayShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPreDayShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPreDayShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ModifyProcList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.ModifyProcList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanActList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPlanActList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSeltWatchList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetSeltWatchList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanActList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPlanActList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipWaitList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetShipWaitList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WritNewPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WritNewPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetOffServerList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetOffServerList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SavePreDayShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SavePreDayShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteProc(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.DeleteProc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNewPlanHstyList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetNewPlanHstyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WritNewPlanHsty(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WritNewPlanHsty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveLineItemShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SaveLineItemShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLinePreDayShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetLinePreDayShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CWPlanSave(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CWPlanSave()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateShipListRun(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdateShipListRun()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateShipInfo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdateShipInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWorkRecorder(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetWorkRecorder()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadPlanProcess(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.LoadPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTaskItemList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetTaskItemList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStartTemplateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetStartTemplateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetRunTemplateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetRunTemplateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanPreDayShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPlanPreDayShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAllTaskList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetAllTaskList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDayList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetDayList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateTempPro(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateTempPro()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdateShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProcess(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.AddProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUploadActList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetUploadActList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteStartTemplateItems(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteStartTemplateItems()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteComplaintList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteComplaintList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAccurateList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetAccurateList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateWorkPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateWorkPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteSurondMoneyList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteSurondMoneyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetComplaintList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetComplaintList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelShipPerDetail(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.DelShipPerDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl WriteRunShipList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.WriteRunShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTemplateTreeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetTemplateTreeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateSerLine(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.UpdateSerLine()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTemplateShipPlanList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetTemplateShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddReportWatch(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.AddReportWatch()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SendInfo(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.SendInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateWatchFact(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateWatchFact()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPlanStateList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetPlanStateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Process
            {
                public _Process(_RPC rt)
                {
                    root = rt;
                    Item = new _Item(rt);
                    DayPlan = new _DayPlan(rt);
                    WatchFact = new _WatchFact(rt);
                    FivePlan = new _FivePlan(rt);
                    TempPlan = new _TempPlan(rt);
                    ShipPlan = new _ShipPlan(rt);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Close(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Close()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddItem(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.AddItem()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Execute(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public class _Item
                {
                    public _Item(_RPC rt)
                    {
                        root = rt;
                    }

                    public IDBDataAtl Load(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Item.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Update(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Item.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Execute(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Item.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _DayPlan
                {
                    public _DayPlan(_RPC rt)
                    {
                        root = rt;
                    }

                    public IDBDataAtl On_DayPlan_Send_Save(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_Send_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_New_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_Send_Approve(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_Send_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _WatchFact
                {
                    public _WatchFact(_RPC rt)
                    {
                        root = rt;
                    }

                    public IDBDataAtl On_WatchFact_New_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WatchFact.On_WatchFact_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WatchFact_Confirm_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WatchFact.On_WatchFact_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WatchFact_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WatchFact.Read_WatchFact_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WatchFact_Send_Approve(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WatchFact.On_WatchFact_Send_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WatchFact_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WatchFact.Read_WatchFact_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WatchFact_Send_Save(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WatchFact.On_WatchFact_Send_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _FivePlan
                {
                    public _FivePlan(_RPC rt)
                    {
                        root = rt;
                    }

                    public IDBDataAtl On_FivePlan_ZGLoad_Back(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_ZGLoad_Back()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_FZLoad_Back(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_FZLoad_Back()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_Confirm_Save(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_Confirm_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_ZGLoad(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_ZGLoad()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_FZLoad_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_FZLoad_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_CW(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_CW()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_FZLoad(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_FZLoad()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_CW_Back(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_CW_Back()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_New_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_Confirm_Ignore(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_Confirm_Ignore()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_ZGLoad_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_ZGLoad_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_CW_Approve(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_CW_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_Confirm_Approve(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_Confirm_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _TempPlan
                {
                    public _TempPlan(_RPC rt)
                    {
                        root = rt;
                    }

                    public IDBDataAtl On_TempPlan_Send_Recv(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.On_TempPlan_Send_Recv()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TempPlan_New_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.On_TempPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TempPlan_Send_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.On_TempPlan_Send_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TempPlan_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.Read_TempPlan_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TempPlan_Send_Reback(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.On_TempPlan_Send_Reback()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TempPlan_DoWith(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.Read_TempPlan_DoWith()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TempPlan_DoWith_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TempPlan.On_TempPlan_DoWith_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _ShipPlan
                {
                    public _ShipPlan(_RPC rt)
                    {
                        root = rt;
                    }

                    public IDBDataAtl On_ShipPlan_Confirm_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_Send_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Send_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_New_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_ShipPlan_Confirm_Loop(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.Read_ShipPlan_Confirm_Loop()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_Confirm_Break(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Confirm_Break()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_ShipPlan_ReConfirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.Read_ShipPlan_ReConfirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_ShipPlan_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.Read_ShipPlan_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_DelayConfirm_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_DelayConfirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_ShipPlan_DelayConfirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.Read_ShipPlan_DelayConfirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_Confirm_Delay(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Confirm_Delay()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_ReConfirm_Cancel(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_ReConfirm_Cancel()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_ShipPlan_Send(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.Read_ShipPlan_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_DelayConfirm_Break(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_DelayConfirm_Break()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_Confirm_Loop_Reback(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Confirm_Loop_Reback()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_Confirm_Loop_Confirm(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Confirm_Loop_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_Confirm_Ignore(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_Confirm_Ignore()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_ShipPlan_ReConfirm_Publish(params object[] args)
                    {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.ShipPlan.On_ShipPlan_ReConfirm_Publish()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                protected _RPC root;
                public _Item Item;
                public _DayPlan DayPlan;
                public _WatchFact WatchFact;
                public _FivePlan FivePlan;
                public _TempPlan TempPlan;
                public _ShipPlan ShipPlan;
            }

            protected _RPC root;
            public _Process Process;
        }

        public class _ShipChangeControl
        {
            public _ShipChangeControl(_RPC rt)
            {
                root = rt;
                ShipChange = new _ShipChange(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateChangeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.UpdateChangeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl PushPlanShipNew(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.PushPlanShipNew()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipChangeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.AddShipChangeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipChangeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.GetShipChangeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CallWS(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.CallWS()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl PushPlanShip(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.PushPlanShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipChange(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.AddShipChange()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipInOutList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.GetShipInOutList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipChangeList1(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.GetShipChangeList1()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSNNumList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.GetSNNumList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _ShipChange
            {
                public _ShipChange(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl UpdateShipChange(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.ShipChange.UpdateShipChange()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.ShipChange.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteShipChange(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipChangeControl.ShipChange.DeleteShipChange()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _ShipChange ShipChange;
        }

        public class _LocationPropertyControl
        {
            public _LocationPropertyControl(_RPC rt)
            {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property
            {
                public _Property(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _CodeCodeControl
        {
            public _CodeCodeControl(_RPC rt)
            {
                root = rt;
                Code = new _Code(rt);
            }

            public IDBDataAtl GetUserCodeList(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.GetUserCodeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args)
            {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Code
            {
                public _Code(_RPC rt)
                {
                    root = rt;
                }

                public IDBDataAtl UpdateProperty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.UpdateProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProperty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.AddProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProperty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.DeleteProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadRegProperty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.LoadRegProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProperty(params object[] args)
                {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.LoadProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Code Code;
        }

        Type _loaderType;
        object _loaderInstance;
        public _ShipPlanControl ShipPlanControl;
        public _CodePropertyControl CodePropertyControl;
        public _LocationControl LocationControl;
        public _EmployeeControl EmployeeControl;
        public _ShipBoxPriceControl ShipBoxPriceControl;
        public _Privilege Privilege;
        public _MessageControl MessageControl;
        public _EmployeePropertyControl EmployeePropertyControl;
        public _ProductPropertyControl ProductPropertyControl;
        public _StartStandControl StartStandControl;
        public _ShipControl ShipControl;
        public _RoleFunctionControl RoleFunctionControl;
        public _ProductControl ProductControl;
        public _JobPropertyControl JobPropertyControl;
        public _ProcessControl ProcessControl;
        public _ShipChangeControl ShipChangeControl;
        public _LocationPropertyControl LocationPropertyControl;
        public _CodeCodeControl CodeCodeControl;
        public _SQLServer SQLServer;
    }
}