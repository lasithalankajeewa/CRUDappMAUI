using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Models
{
    public class UserPermission
    {
        private int objKy;
        private int isAllowAccess;
        private int isAllowAdd;
        private int isAllowUpdate;
        private int isAllowDelete;
        private int isAllowApprove;

        public int ObjKy { get => objKy; set => objKy = value; }
        public int IsAllowAccess { get => isAllowAccess; set => isAllowAccess = value; }
        public int IsAllowAdd { get => isAllowAdd; set => isAllowAdd = value; }
        public int IsAllowUpdate { get => isAllowUpdate; set => isAllowUpdate = value; }
        public int IsAllowDelete { get => isAllowDelete; set => isAllowDelete = value; }
        public int IsAllowApprove { get => isAllowApprove; set => isAllowApprove = value; }
    }
}
