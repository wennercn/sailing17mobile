using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using ATLDATALib;

namespace sailing17Mobile {
    public class _RPC {
        public _RPC() {
            _loaderType = Type.GetTypeFromCLSID(new Guid("{45DD3EDD-0E5F-40a7-BECF-672AEFF0E293}"));
            _loaderInstance = System.Activator.CreateInstance(_loaderType);
            ShipPlanControl = new _ShipPlanControl(this);
            StoreMeetControl = new _StoreMeetControl(this);
            CodePropertyControl = new _CodePropertyControl(this);
            CalendarControl = new _CalendarControl(this);
            LocationControl = new _LocationControl(this);
            InterviewControl = new _InterviewControl(this);
            EmployeeControl = new _EmployeeControl(this);
            ShipMeetControl = new _ShipMeetControl(this);
            PayMoneyControl = new _PayMoneyControl(this);
            Privilege = new _Privilege(this);
            ConstructControl = new _ConstructControl(this);
            MessageControl = new _MessageControl(this);
            EmployeePropertyControl = new _EmployeePropertyControl(this);
            ProductPropertyControl = new _ProductPropertyControl(this);
            ChangeCarryControl = new _ChangeCarryControl(this);
            CustEventControl = new _CustEventControl(this);
            ShipControl = new _ShipControl(this);
            RoleFunctionControl = new _RoleFunctionControl(this);
            SPayMoneyControl = new _SPayMoneyControl(this);
            ProductControl = new _ProductControl(this);
            SafeCaseControl = new _SafeCaseControl(this);
            JobPropertyControl = new _JobPropertyControl(this);
            ProcessControl = new _ProcessControl(this);
            ContractControl = new _ContractControl(this);
            NewTechControl = new _NewTechControl(this);
            TechnicsControl = new _TechnicsControl(this);
            LocationPropertyControl = new _LocationPropertyControl(this);
            CodeCodeControl = new _CodeCodeControl(this);
            TrainPlanControl = new _TrainPlanControl(this);
            WaitTimeControl = new _WaitTimeControl(this);
            Oracle = new _Oracle(this);
            Oracle3 = new _Oracle3(this);
        }

        public void SetSession(params object[] args) {
            _loaderType.InvokeMember("SetSession", BindingFlags.InvokeMethod | BindingFlags.Public, null, _loaderInstance, args);
        }


        public class _ShipPlanControl {
            public _ShipPlanControl(_RPC rt) {
                root = rt;
                ShipPlan = new _ShipPlan(rt);
            }

            public IDBDataAtl UpdateEditItem(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateEditItem()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl MoveDock(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.MoveDock()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetFiveList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetFiveList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetFiveProductList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetFiveProductList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadSingeProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.LoadSingeProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl PurDelClassMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.PurDelClassMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateChangeList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateChangeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetOldShipPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetOldShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreatePlanList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.CreatePlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateDynamicShipPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateDynamicShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetShipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNoSeqShipPlanList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetNoSeqShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadHstyProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.LoadHstyProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCancelList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateCancelList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelClassMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.DelClassMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddDynamicShipPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.AddDynamicShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDynamicList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetDynamicList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDepDynamicList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetDepDynamicList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDepConfirmList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetDepConfirmList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWorkShiftList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetWorkShiftList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl MoveDockIn(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.MoveDockIn()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetClassMeetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetClassMeetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateClassMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.CreateClassMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipPlanList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetShipPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetInPortShip(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetInPortShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.AddShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnCompleteList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetUnCompleteList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetEditItemList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetEditItemList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDynamicPlanList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetDynamicPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl EditFactSinglePlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.EditFactSinglePlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateSinglePlanShip(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.CreateSinglePlanShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDayNightPreList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetDayNightPreList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetEditItemDayList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetEditItemDayList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl TacheCheck(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.TacheCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl TailStatus(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.TailStatus()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnMatchingShipList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetUnMatchingShipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDayNightList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetDayNightList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateDynamicShipPlanNew(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateDynamicShipPlanNew()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateFactSinglePlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateFactSinglePlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnShipMeetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.GetUnShipMeetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ListPlanShip(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ListPlanShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateClassMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.UpdateClassMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _ShipPlan {
                public _ShipPlan(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl ToDynamicShip(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.ToDynamicShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl InsertShip(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.InsertShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateCancelShipMeet(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateCancelShipMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddSinglePlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.AddSinglePlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddSingleMain(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.AddSingleMain()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateWorkBaseTon(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateWorkBaseTon()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProductInfo(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateProductInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipPlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateShipPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateSinglePlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateSinglePlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProductInfo(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DeleteProductInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateSingleMain(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateSingleMain()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddShipCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.AddShipCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelWorkBaseTon(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DelWorkBaseTon()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LeavePort(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.LeavePort()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadInvo(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.LoadInvo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeletePlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DeletePlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveShip(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.RemoveShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl MoveShip(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.MoveShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelayShip(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DelayShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelSinglePlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DelSinglePlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddWorkBaseTon(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.AddWorkBaseTon()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProductInfo(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.AddProductInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateWorkShift(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateWorkShift()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelSingleMain(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DelSingleMain()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipPlanProcess(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateShipPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl CloseWorkShift(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.CloseWorkShift()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.UpdateShipCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteShipCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipPlanControl.ShipPlan.DeleteShipCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _ShipPlan ShipPlan;
        }

        public class _StoreMeetControl {
            public _StoreMeetControl(_RPC rt) {
                root = rt;
                StroeMeet = new _StroeMeet(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNewStoreMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.GetNewStoreMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStoreMeetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.GetStoreMeetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddStoreMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.AddStoreMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _StroeMeet {
                public _StroeMeet(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.StroeMeet.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteStoreMeet(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.StroeMeet.PureDeleteStoreMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteStoreMeet(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.StroeMeet.DeleteStoreMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateStoreMeet(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.StoreMeetControl.StroeMeet.UpdateStoreMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _StroeMeet StroeMeet;
        }

        public class _CodePropertyControl {
            public _CodePropertyControl(_RPC rt) {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property {
                public _Property(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodePropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _CalendarControl {
            public _CalendarControl(_RPC rt) {
                root = rt;
                Calendar = new _Calendar(rt);
            }

            public IDBDataAtl GetProdKindMonthList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetProdKindMonthList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCalendarList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetCalendarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStateEndList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetStateEndList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAnyMonthListTwo(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetAnyMonthListTwo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateStateDetail(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.UpdateStateDetail()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAllYearList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetAllYearList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCustMonthList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetCustMonthList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCustVipList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetCustVipList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetKindList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelCustVip(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.DelCustVip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStatProdList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetStatProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelProdKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.DelProdKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCalendarList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.UpdateCalendarList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetDiffToneList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetDiffToneList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl InsertProdKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.InsertProdKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCustList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetCustList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStorageStatList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetStorageStatList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl InitMonth(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.InitMonth()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStateList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetStateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAnyMonthListOne(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetAnyMonthListOne()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetStateConfList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetStateConfList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetProdKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCustProdList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetCustProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl MarkCustVip(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.MarkCustVip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddCalendar(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.AddCalendar()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdUnKindList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetProdUnKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUnStateList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetUnStateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetThroughputList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.GetThroughputList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl SaveStateList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.SaveStateList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Calendar {
                public _Calendar(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl DeleteCalendar(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.Calendar.DeleteCalendar()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.Calendar.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteCalendar(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.Calendar.PureDeleteCalendar()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateCalendar(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CalendarControl.Calendar.UpdateCalendar()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Calendar Calendar;
        }

        public class _LocationControl {
            public _LocationControl(_RPC rt) {
                root = rt;
                Location = new _Location(rt);
            }

            public IDBDataAtl GetProdList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLocSelectList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetLocSelectList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAllCustInfoList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetAllCustInfoList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentLoc(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetAcidentLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddLocation(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.AddLocation()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetRepairLoc(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetRepairLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLocList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.GetLocList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Location {
                public _Location(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddLocProdKind(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.AddLocProdKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl MoveEmployee(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.MoveEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.DelAcidentLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateRepairLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.UpdateRepairLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddEmployee(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.AddEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.DeleteLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.AddAcidentLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelRepairLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.DelRepairLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetEmployeeList(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.GetEmployeeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.UpdateLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddRepairLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.AddRepairLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetCustProdList(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.GetCustProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveEmployee(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.RemoveEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteLocProdKind(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.DeleteLocProdKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.PureDeleteLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentLoc(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationControl.Location.UpdateAcidentLoc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Location Location;
        }

        public class _InterviewControl {
            public _InterviewControl(_RPC rt) {
                root = rt;
                Interview = new _Interview(rt);
            }

            public IDBDataAtl GetInterviewList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.GetInterviewList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateInterviewProc(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.CreateInterviewProc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddInterview(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.AddInterview()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetInterviewProc(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.GetInterviewProc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CloseInterviewProc(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.CloseInterviewProc()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Interview {
                public _Interview(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl UpdateInterview(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.UpdateInterview()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelItw(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.DelItw()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetInterviewEmp(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.GetInterviewEmp()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateItw(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.UpdateItw()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddItw(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.AddItw()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteInterview(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.DeleteInterview()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteInterview(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.InterviewControl.Interview.PureDeleteInterview()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Interview Interview;
        }

        public class _EmployeeControl {
            public _EmployeeControl(_RPC rt) {
                root = rt;
                Employee = new _Employee(rt);
            }

            public IDBDataAtl GetPrivilegeList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetPrivilegeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadPrivilege(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.LoadPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddEmployee(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.AddEmployee()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetLocEmpInfo(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetLocEmpInfo()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetEmpList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.GetEmpList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Employee {
                public _Employee(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl GetRole(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.GetRole()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadMore(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.LoadMore()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl CheckPrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.CheckPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDelete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.PureDelete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveLocation(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.RemoveLocation()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Login(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Login()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveRole(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.RemoveRole()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Logout(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Logout()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetLocationList(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.GetLocationList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemovePrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.RemovePrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateKey(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.UpdateKey()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl CheckPassword(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.CheckPassword()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddLocation(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddLocation()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetPrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.GetPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddTrainEmp(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddTrainEmp()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddRole(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeeControl.Employee.AddRole()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Employee Employee;
        }

        public class _ShipMeetControl {
            public _ShipMeetControl(_RPC rt) {
                root = rt;
                ShipMeet = new _ShipMeet(rt);
            }

            public IDBDataAtl AddShipMeetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.AddShipMeetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelSpectable(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.DelSpectable()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddSpectable(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.AddSpectable()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipMeetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.GetShipMeetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ModifySpectable(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.ModifySpectable()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShipMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.AddShipMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateShipMeetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.UpdateShipMeetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl FindSpectable(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.FindSpectable()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _ShipMeet {
                public _ShipMeet(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.ShipMeet.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShipMeet(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.ShipMeet.UpdateShipMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteShipMeet(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipMeetControl.ShipMeet.DeleteShipMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _ShipMeet ShipMeet;
        }

        public class _PayMoneyControl {
            public _PayMoneyControl(_RPC rt) {
                root = rt;
                PayMoney = new _PayMoney(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPayMoneyList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.GetPayMoneyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPayMoney(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.AddPayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _PayMoney {
                public _PayMoney(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl DeletePayMoney(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.PayMoney.DeletePayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.PayMoney.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeletePayMoney(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.PayMoney.PureDeletePayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePayMoney(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.PayMoneyControl.PayMoney.UpdatePayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _PayMoney PayMoney;
        }

        public class _Privilege {
            public _Privilege(_RPC rt) {
                root = rt;
                Product = new _Product(rt);
            }

            public IDBDataAtl GetAcidentProd(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DeleteCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdatePressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPipeCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetPipeCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentMach(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdateCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachFactory(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetMachFactory()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DelPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachDep(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetMachDep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProduct(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddProduct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ImpMachToDB(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.ImpMachToDB()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.AddPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.GetPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKindList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdateCrmKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.DelPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.UpdatePipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Product {
                public _Product(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl AddPressCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPipeCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPipeCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentMach(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdateAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePressCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdatePressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentMach(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.PureDeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPressCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.DelPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePipeCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.UpdatePipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentMach(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Privilege.Product.AddAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Product Product;
        }

        public class _ConstructControl {
            public _ConstructControl(_RPC rt) {
                root = rt;
                Construct = new _Construct(rt);
            }

            public IDBDataAtl AddConstruct(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.AddConstruct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetConstructList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.GetConstructList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetConstructEffect(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.GetConstructEffect()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateConstructEffect(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.UpdateConstructEffect()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddConstructEffect(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.AddConstructEffect()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteConstructEffect(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.DeleteConstructEffect()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Construct {
                public _Construct(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl DeleteConstruct(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.Construct.DeleteConstruct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteConstruct(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.Construct.PureDeleteConstruct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateConstruct(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.Construct.UpdateConstruct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ConstructControl.Construct.Load ()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Construct Construct;
        }

        public class _MessageControl {
            public _MessageControl(_RPC rt) {
                root = rt;
                Message = new _Message(rt);
            }

            public IDBDataAtl GetMessageStatusList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.GetMessageStatusList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddMessage(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.AddMessage()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetUserMessageList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.GetUserMessageList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMessageUnreadList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.GetMessageUnreadList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Message {
                public _Message(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl MarkMessageReaden(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.MarkMessageReaden()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.MessageControl.Message.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Message Message;
        }

        public class _EmployeePropertyControl {
            public _EmployeePropertyControl(_RPC rt) {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property {
                public _Property(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.EmployeePropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _ProductPropertyControl {
            public _ProductPropertyControl(_RPC rt) {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property {
                public _Property(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductPropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _ChangeCarryControl {
            public _ChangeCarryControl(_RPC rt) {
                root = rt;
                ChangeCarry = new _ChangeCarry(rt);
            }

            public IDBDataAtl UpdateChangeCarryPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.UpdateChangeCarryPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddChangeCarry(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.AddChangeCarry()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetChangeCarryList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.GetChangeCarryList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateChangeCarryPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.CreateChangeCarryPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _ChangeCarry {
                public _ChangeCarry(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl UpdateChangeCarry(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.ChangeCarry.UpdateChangeCarry()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.ChangeCarry.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteChangeCarry(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.ChangeCarry.DeleteChangeCarry()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteChangeCarry(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ChangeCarryControl.ChangeCarry.PureDeleteChangeCarry()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _ChangeCarry ChangeCarry;
        }

        public class _CustEventControl {
            public _CustEventControl(_RPC rt) {
                root = rt;
                CustEvent = new _CustEvent(rt);
            }

            public IDBDataAtl GetCustEventList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CustEventControl.GetCustEventList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddCustEvent(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CustEventControl.AddCustEvent()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _CustEvent {
                public _CustEvent(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CustEventControl.CustEvent.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteEvent(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CustEventControl.CustEvent.PureDeleteEvent()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateEvent(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CustEventControl.CustEvent.UpdateEvent()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteEvent(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CustEventControl.CustEvent.DeleteEvent()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _CustEvent CustEvent;
        }

        public class _ShipControl {
            public _ShipControl(_RPC rt) {
                root = rt;
                Ship = new _Ship(rt);
            }

            public IDBDataAtl GetShipsNameList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetShipsNameList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCheckShips(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetCheckShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddShip(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.AddShip()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetShipsList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetShipsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentShips(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.GetAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Ship {
                public _Ship(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl PureDeleteShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.PureDeleteShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddCheckShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.AddCheckShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.UpdateAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateCheckShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.UpdateCheckShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.UpdateShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.AddAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.DeleteShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelCheckShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.DelCheckShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentShips(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ShipControl.Ship.DelAcidentShips()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Ship Ship;
        }

        public class _RoleFunctionControl {
            public _RoleFunctionControl(_RPC rt) {
                root = rt;
                RoleFunction = new _RoleFunction(rt);
            }

            public IDBDataAtl GetRoleFunctionList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.GetRoleFunctionList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddRoleFunction(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.AddRoleFunction()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _RoleFunction {
                public _RoleFunction(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl GetPrivilegeList(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.GetPrivilegeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl GetRoleFunctionList(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.GetRoleFunctionList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadPrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.LoadPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemovePrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.RemovePrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl RemoveRoleFunction(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.RemoveRoleFunction()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPrivilege(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.AddPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddRoleFunction(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.RoleFunctionControl.RoleFunction.AddRoleFunction()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _RoleFunction RoleFunction;
        }

        public class _SPayMoneyControl {
            public _SPayMoneyControl(_RPC rt) {
                root = rt;
                SPayMoney = new _SPayMoney(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetSPayMoneyList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.GetSPayMoneyList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddSPayMoney(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.AddSPayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateSPayList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.UpdateSPayList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _SPayMoney {
                public _SPayMoney(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.SPayMoney.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteSPayMoney(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.SPayMoney.DeleteSPayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteSPayMoney(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.SPayMoney.PureDeleteSPayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateSPayMoney(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SPayMoneyControl.SPayMoney.UpdateSPayMoney()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _SPayMoney SPayMoney;
        }

        public class _ProductControl {
            public _ProductControl(_RPC rt) {
                root = rt;
                Product = new _Product(rt);
            }

            public IDBDataAtl GetAcidentProd(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DeleteCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DeleteCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdatePressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPipeCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetPipeCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetAcidentMach(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdateCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetProdList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetProdList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetCrmKind(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetCrmKind()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachFactory(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetMachFactory()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DelPipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetMachDep(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetMachDep()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProduct(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddProduct()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl ImpMachToDB(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.ImpMachToDB()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddPressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.AddPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetPressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.GetPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdateCrmKindList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdateCrmKindList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl DelPressCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.DelPressCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl UpdatePipCheckList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.UpdatePipCheckList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Product {
                public _Product(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl AddPressCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPipeCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddPipeCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddPipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentMach(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdateAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePressCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdatePressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentMach(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.PureDeleteProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentProd(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddAcidentProd()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelPressCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.DelPressCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdatePipeCheck(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.UpdatePipeCheck()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentMach(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProductControl.Product.AddAcidentMach()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Product Product;
        }

        public class _SafeCaseControl {
            public _SafeCaseControl(_RPC rt) {
                root = rt;
                SafeCase = new _SafeCase(rt);
            }

            public IDBDataAtl GetSafeList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SafeCaseControl.GetSafeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddSafeCase(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SafeCaseControl.AddSafeCase()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _SafeCase {
                public _SafeCase(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl DeleteSafe(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SafeCaseControl.SafeCase.DeleteSafe()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SafeCaseControl.SafeCase.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteSafe(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SafeCaseControl.SafeCase.PureDeleteSafe()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateSafe(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.SafeCaseControl.SafeCase.UpdateSafe()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _SafeCase SafeCase;
        }

        public class _JobPropertyControl {
            public _JobPropertyControl(_RPC rt) {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property {
                public _Property(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.JobPropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _ProcessControl {
            public _ProcessControl(_RPC rt) {
                root = rt;
                Process = new _Process(rt);
            }

            public IDBDataAtl GetProcessList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.GetProcessList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreatePayMoneyMProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreatePayMoneyMProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateYJTechManagersProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateYJTechManagersProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateSinglePlanProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateSinglePlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateNewTechProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateNewTechProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateChangeCarryPlanProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateChangeCarryPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NewVariant(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.NewVariant()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateDayDraftPlanProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateDayDraftPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowTime(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.NowTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl NowDate(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.NowDate()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateSPayMoneyMProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateSPayMoneyMProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateFivePlanProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateFivePlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.AddProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateWaitTimeProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateWaitTimeProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateTrainPlanProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateTrainPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateDayPlanProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateDayPlanProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateTechManagersProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateTechManagersProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateStoreMeet(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateStoreMeet()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl CreateUpdateMarkProcessPrivilege(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.CreateUpdateMarkProcessPrivilege()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Process {
                public _Process(_RPC rt) {
                    root = rt;
                    Item = new _Item(rt);
                    PayMoneyM = new _PayMoneyM(rt);
                    NewTechM = new _NewTechM(rt);
                    YJTechManagers = new _YJTechManagers(rt);
                    TrainPlan = new _TrainPlan(rt);
                    DayDraftPlan = new _DayDraftPlan(rt);
                    StoreMeetM = new _StoreMeetM(rt);
                    WaitTime = new _WaitTime(rt);
                    SinglePlan = new _SinglePlan(rt);
                    TechManagers = new _TechManagers(rt);
                    CarryPlan = new _CarryPlan(rt);
                    SPayMoneyM = new _SPayMoneyM(rt);
                    DayPlan = new _DayPlan(rt);
                    FivePlan = new _FivePlan(rt);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Close(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Close()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddItem(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.AddItem()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Execute(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public class _Item {
                    public _Item(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl Load(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Item.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Update(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Item.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Execute(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.Item.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _PayMoneyM {
                    public _PayMoneyM(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_PayMoneyM_Manager_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Manager_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_PayMoneyM_Pay(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.Read_PayMoneyM_Pay()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Pay_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Pay_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Goods_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Goods_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_PayMoneyM_Goods(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.Read_PayMoneyM_Goods()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Pay_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Pay_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Book_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Book_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Goods_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Goods_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Book_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Book_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_PayMoneyM_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.Read_PayMoneyM_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_PayMoneyM_Location(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.Read_PayMoneyM_Location()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_PayMoneyM_Manager(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.Read_PayMoneyM_Manager()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_PayMoneyM_Location_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.PayMoneyM.On_PayMoneyM_Location_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _NewTechM {
                    public _NewTechM(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl Read_NewTechM_HY(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_HY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_NewTechM_DD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_DD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_NewTechM_SC(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_SC()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_NewTechM_Leader(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_Leader()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_Manager_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_Manager_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_GJ_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_GJ_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_NewTechM_GJ(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_GJ()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_NewTechM_Manager(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_Manager()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_SC_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_SC_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_SC_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_SC_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_NewTechM_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.Read_NewTechM_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_GJ_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_GJ_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_Leader_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_Leader_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_Leader_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_Leader_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_Manager_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_Manager_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_HY_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_HY_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_DD_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_DD_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_DD_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_DD_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_NewTechM_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.NewTechM.On_NewTechM_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _YJTechManagers {
                    public _YJTechManagers(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_YJTechManagers_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.On_YJTechManagers_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_YJTechManagers_DD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.Read_YJTechManagers_DD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_YJTechManagers_AJ_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.On_YJTechManagers_AJ_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_YJTechManagers_DD_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.On_YJTechManagers_DD_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_YJTechManagers_AJ_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.On_YJTechManagers_AJ_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_YJTechManagers_AJ(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.Read_YJTechManagers_AJ()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_YJTechManagers_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.On_YJTechManagers_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_YJTechManagers_DD_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.On_YJTechManagers_DD_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_YJTechManagers_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.YJTechManagers.Read_YJTechManagers_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _TrainPlan {
                    public _TrainPlan(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_TrainPlan_Write_Modify(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.On_TrainPlan_Write_Modify()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_Train_Write(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.Read_Train_Write()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TrainPlan_Reader_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.On_TrainPlan_Reader_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TrainPlan_Record(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.Read_TrainPlan_Record()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TrainPlan_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.On_TrainPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TrainPlan_Record_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.On_TrainPlan_Record_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_Train_Reader(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.Read_Train_Reader()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TrainPlan_Write_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.On_TrainPlan_Write_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TrainPlan_Record_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.On_TrainPlan_Record_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TrainPlan_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TrainPlan.Read_TrainPlan_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _DayDraftPlan {
                    public _DayDraftPlan(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_DayDraftPlan_Record_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_Record_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_AJ_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_AJ_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_SC_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_SC_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_Record_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_Record_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_GJ_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_GJ_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_GJ_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_GJ_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_JD_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_JD_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_AJ_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_AJ_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_HY_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_HY_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_HY_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_HY_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_DD_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_DD_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayDraftPlan_Record(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.Read_DayDraftPlan_Record()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_DD_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_DD_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_JD_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_JD_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayDraftPlan_SC_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayDraftPlan.On_DayDraftPlan_SC_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _StoreMeetM {
                    public _StoreMeetM(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl Read_StoreMeetM_Record(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.StoreMeetM.Read_StoreMeetM_Record()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_StoreMeetM_Record_End(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.StoreMeetM.On_StoreMeetM_Record_End()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_StoreMeetM_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.StoreMeetM.On_StoreMeetM_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_StoreMeetM_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.StoreMeetM.On_StoreMeetM_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_StoreMeet_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.StoreMeetM.Read_StoreMeet_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_StoreMeetM_Record_Modify(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.StoreMeetM.On_StoreMeetM_Record_Modify()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _WaitTime {
                    public _WaitTime(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_WaitTime_DDDoWith_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_DDDoWith_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_SCManager_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_SCManager_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_SCManager(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_SCManager()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_DDManager_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_DDManager_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_DutyPer(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_DutyPer()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_RQWrite_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_RQWrite_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_SelfDuty_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_SelfDuty_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_DutyPer(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_DutyPer()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_DDDoWith_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_DDDoWith_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_DDManager(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_DDManager()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_SelfDuty(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_SelfDuty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_RQWrite(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_RQWrite()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_RQWrite_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_RQWrite_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_SCManager_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_SCManager_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_WaitTime_DDDoWith(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.Read_WaitTime_DDDoWith()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_SelfDuty_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_SelfDuty_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_WaitTime_DDManager_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.WaitTime.On_WaitTime_DDManager_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _SinglePlan {
                    public _SinglePlan(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_SinglePlan_Manager_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.On_SinglePlan_Manager_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SinglePlan_Manager_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.On_SinglePlan_Manager_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SinglePlan_FactData_FactEdit(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.On_SinglePlan_FactData_FactEdit()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SinglePlan_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.Read_SinglePlan_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SinglePlan_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.On_SinglePlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SinglePlan_FactData(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.Read_SinglePlan_FactData()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SinglePlan_Manager(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SinglePlan.Read_SinglePlan_Manager()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _TechManagers {
                    public _TechManagers(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_TechManagers_DD_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_DD_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TechManagers_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.Read_TechManagers_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_LT_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_LT_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TechManagers_LT(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.Read_TechManagers_LT()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TechManagers_AJ(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.Read_TechManagers_AJ()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_SC_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_SC_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_SC_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_SC_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_HY_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_HY_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_AJ_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_AJ_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_HY_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_HY_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TechManagers_HY(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.Read_TechManagers_HY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TechManagers_DD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.Read_TechManagers_DD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_TechManagers_SC(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.Read_TechManagers_SC()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_AJ_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_AJ_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_DD_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_DD_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_LT_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_LT_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_TechManagers_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.TechManagers.On_TechManagers_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _CarryPlan {
                    public _CarryPlan(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_CarryPlan_JD_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.On_CarryPlan_JD_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_CarryPlan_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.Read_CarryPlan_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_CarryPlan_DD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.Read_CarryPlan_DD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_CarryPlan_DD_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.On_CarryPlan_DD_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_CarryPlan_DD_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.Read_CarryPlan_DD_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_CarryPlan_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.On_CarryPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_CarryPlan_DD_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.On_CarryPlan_DD_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_CarryPlan_JD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.CarryPlan.Read_CarryPlan_JD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _SPayMoneyM {
                    public _SPayMoneyM(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_SPayMoneyM_New_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_New_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_Goods_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_Goods_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_SPay_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_SPay_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SPayMoneyM_SPay(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.Read_SPayMoneyM_SPay()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_Book_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_Book_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SPayMoneyM_Book(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.Read_SPayMoneyM_Book()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_SPay_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_SPay_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SPayMoneyM_Goods(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.Read_SPayMoneyM_Goods()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_SPayMoneyM_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.Read_SPayMoneyM_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_Goods_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_Goods_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_SPayMoneyM_Book_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.SPayMoneyM.On_SPayMoneyM_Book_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _DayPlan {
                    public _DayPlan(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_DayPlan_HY_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_HY_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_Record(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_Record()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_GJ_Repair(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_GJ_Repair()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_SC_Confirm_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_SC_Confirm_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_DD_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_DD_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_SC_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_SC_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_JD_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_JD_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_GJ_Repair_Modify(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_GJ_Repair_Modify()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_AJ_Repair(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_AJ_Repair()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_JD_Repair(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_JD_Repair()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_GJ_Confirm_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_GJ_Confirm_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_SC_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_SC_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_DD_Repair(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_DD_Repair()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_AJ_Confirm_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_AJ_Confirm_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_GJ_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_GJ_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_DD_Repair_Modify(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_DD_Repair_Modify()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_AJ_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_AJ_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_HY_Confirm_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_HY_Confirm_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_JD_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_JD_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_JD_Confirm_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_JD_Confirm_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_GJ_Confirm_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_GJ_Confirm_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_AJ_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_AJ_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_HY_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_HY_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_Record_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_Record_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_Record_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_Record_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_AJ_Repair_Modify(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_AJ_Repair_Modify()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_DayPlan_DD_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.Read_DayPlan_DD_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_DayPlan_JD_Repair_Modify(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.DayPlan.On_DayPlan_JD_Repair_Modify()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                public class _FivePlan {
                    public _FivePlan(_RPC rt) {
                        root = rt;
                    }

                    public IDBDataAtl On_FivePlan_AJ_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_AJ_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_JD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_JD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_HY_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_HY_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_Record_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_Record_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_DDLT(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_DDLT()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_SC_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_SC_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_GJ_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_GJ_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_Record(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_Record()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_DD_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_DD_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_LT_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_LT_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_New(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_New()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_HY_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_HY_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_DD(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_DD()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_HY(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_HY()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_SC(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_SC()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_DDLT_Confirm(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_DDLT_Confirm()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_AJ_PApprove(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_AJ_PApprove()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_GJ(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_GJ()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_JD_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_JD_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_GJ_PApprove(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_GJ_PApprove()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_HY_PApprove(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_HY_PApprove()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_SC_PApprove(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_SC_PApprove()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_New_Send(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_New_Send()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_SC_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_SC_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_LT_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_LT_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_GJ_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_GJ_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_LT(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_LT()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_LT_PApprove(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_LT_PApprove()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_AJ_Save(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_AJ_Save()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl Read_FivePlan_AJ(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.Read_FivePlan_AJ()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_JD_Approve(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_JD_Approve()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_JD_PApprove(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_JD_PApprove()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }

                    public IDBDataAtl On_FivePlan_Record_Reject(params object[] args) {
                        return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ProcessControl.Process.FivePlan.On_FivePlan_Record_Reject()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                    }


                    protected _RPC root;
                }

                protected _RPC root;
                public _Item Item;
                public _PayMoneyM PayMoneyM;
                public _NewTechM NewTechM;
                public _YJTechManagers YJTechManagers;
                public _TrainPlan TrainPlan;
                public _DayDraftPlan DayDraftPlan;
                public _StoreMeetM StoreMeetM;
                public _WaitTime WaitTime;
                public _SinglePlan SinglePlan;
                public _TechManagers TechManagers;
                public _CarryPlan CarryPlan;
                public _SPayMoneyM SPayMoneyM;
                public _DayPlan DayPlan;
                public _FivePlan FivePlan;
            }

            protected _RPC root;
            public _Process Process;
        }

        public class _ContractControl {
            public _ContractControl(_RPC rt) {
                root = rt;
                Contract = new _Contract(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetContractList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.GetContractList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddContract(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.AddContract()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Contract {
                public _Contract(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl UpdateWaitTime(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.Contract.UpdateWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.Contract.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteWaitTime(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.Contract.DeleteWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteWaitTime(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.ContractControl.Contract.PureDeleteWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Contract Contract;
        }

        public class _NewTechControl {
            public _NewTechControl(_RPC rt) {
                root = rt;
                NewTech = new _NewTech(rt);
            }

            public IDBDataAtl AddNewTech(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.AddNewTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetNewTechList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.GetNewTechList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _NewTech {
                public _NewTech(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl UpdateNewTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.NewTech.UpdateNewTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.NewTech.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteNewTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.NewTech.PureDeleteNewTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteNewTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.NewTechControl.NewTech.DeleteNewTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _NewTech NewTech;
        }

        public class _TechnicsControl {
            public _TechnicsControl(_RPC rt) {
                root = rt;
                Technics = new _Technics(rt);
            }

            public IDBDataAtl AddTechnics(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.AddTechnics()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTechnicsList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.GetTechnicsList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTechAcidentList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.GetTechAcidentList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Technics {
                public _Technics(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateAcidentTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.UpdateAcidentTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.UpdateTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.DeleteTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DelAcidentTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.DelAcidentTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.PureDeleteTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddAcidentTech(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TechnicsControl.Technics.AddAcidentTech()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Technics Technics;
        }

        public class _LocationPropertyControl {
            public _LocationPropertyControl(_RPC rt) {
                root = rt;
                Property = new _Property(rt);
            }

            public IDBDataAtl GetList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.GetList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Property {
                public _Property(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Property.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Property.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.LocationPropertyControl.Property.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Property Property;
        }

        public class _CodeCodeControl {
            public _CodeCodeControl(_RPC rt) {
                root = rt;
                Code = new _Code(rt);
            }

            public IDBDataAtl GetUserCodeList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.GetUserCodeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Add(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Add()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _Code {
                public _Code(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl UpdateProperty(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.UpdateProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl AddProperty(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.AddProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteProperty(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.DeleteProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Update(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.Update()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadRegProperty(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.LoadRegProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Delete(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.Delete()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl LoadProperty(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.CodeCodeControl.Code.LoadProperty()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _Code Code;
        }

        public class _TrainPlanControl {
            public _TrainPlanControl(_RPC rt) {
                root = rt;
                TrainPlan = new _TrainPlan(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetTrainPlanList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.GetTrainPlanList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddTrainPlan(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.AddTrainPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _TrainPlan {
                public _TrainPlan(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl DeleteTrainPlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.TrainPlan.DeleteTrainPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteTrainPlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.TrainPlan.PureDeleteTrainPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl UpdateTrainPlan(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.TrainPlan.UpdateTrainPlan()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.TrainPlanControl.TrainPlan.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _TrainPlan TrainPlan;
        }

        public class _WaitTimeControl {
            public _WaitTimeControl(_RPC rt) {
                root = rt;
                WaitTime = new _WaitTime(rt);
            }

            public IDBDataAtl LoadProcess(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.LoadProcess()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl GetWaitTimeList(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.GetWaitTimeList()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl AddWaitTime(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.AddWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public class _WaitTime {
                public _WaitTime(_RPC rt) {
                    root = rt;
                }

                public IDBDataAtl UpdateWaitTime(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.WaitTime.UpdateWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl Load(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.WaitTime.Load()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl DeleteWaitTime(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.WaitTime.DeleteWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }

                public IDBDataAtl PureDeleteWaitTime(params object[] args) {
                    return (IDBDataAtl)root._loaderType.InvokeMember("RPC.WaitTimeControl.WaitTime.PureDeleteWaitTime()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
                }


                protected _RPC root;
            }

            protected _RPC root;
            public _WaitTime WaitTime;
        }

        public class _Oracle {
            public _Oracle(_RPC rt) {
                root = rt;

            }
            public IDBDataAtl BeginWork(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle.BeginWork()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Select(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle.Select()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Execute(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Rollback(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle.Rollback()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Commit(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle.Commit()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            protected _RPC root;

        }

        public class _Oracle3 {
            public _Oracle3(_RPC rt) {
                root = rt;

            }
            public IDBDataAtl BeginWork(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle3.BeginWork()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Select(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle3.Select()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            public IDBDataAtl Execute(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle3.Execute()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Rollback(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle3.Rollback()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }
            public IDBDataAtl Commit(params object[] args) {
                return (IDBDataAtl)root._loaderType.InvokeMember("RPC.Oracle3.Commit()", BindingFlags.InvokeMethod | BindingFlags.Public, null, root._loaderInstance, args);
            }

            protected _RPC root;

        }



        Type _loaderType;
        object _loaderInstance;
        public _ShipPlanControl ShipPlanControl;
        public _StoreMeetControl StoreMeetControl;
        public _CodePropertyControl CodePropertyControl;
        public _CalendarControl CalendarControl;
        public _LocationControl LocationControl;
        public _InterviewControl InterviewControl;
        public _EmployeeControl EmployeeControl;
        public _ShipMeetControl ShipMeetControl;
        public _PayMoneyControl PayMoneyControl;
        public _Privilege Privilege;
        public _ConstructControl ConstructControl;
        public _MessageControl MessageControl;
        public _EmployeePropertyControl EmployeePropertyControl;
        public _ProductPropertyControl ProductPropertyControl;
        public _ChangeCarryControl ChangeCarryControl;
        public _CustEventControl CustEventControl;
        public _ShipControl ShipControl;
        public _RoleFunctionControl RoleFunctionControl;
        public _SPayMoneyControl SPayMoneyControl;
        public _ProductControl ProductControl;
        public _SafeCaseControl SafeCaseControl;
        public _JobPropertyControl JobPropertyControl;
        public _ProcessControl ProcessControl;
        public _ContractControl ContractControl;
        public _NewTechControl NewTechControl;
        public _TechnicsControl TechnicsControl;
        public _LocationPropertyControl LocationPropertyControl;
        public _CodeCodeControl CodeCodeControl;
        public _TrainPlanControl TrainPlanControl;
        public _WaitTimeControl WaitTimeControl;
        public _Oracle Oracle;
        public _Oracle3 Oracle3;
    }

}