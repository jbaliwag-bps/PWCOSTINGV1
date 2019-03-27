using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PWCOSTING.BO._000;
using PWCOSTING.BO._100;
using PWCOSTING.BO.Default;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace PWCOSTING.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
            : base(Common.ConnectionString)
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        //Override the Decimal Precision of EF
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(18, 4)); //default: (18,2)
        }

        //Default Entities
        public DbSet<tbl_MENU> MenuList { get; set; }
        public DbSet<tbl_YEAR> YearList { get; set; }

        //000 Entities
        public DbSet<tbl_000_COMPANY> CompanyList { get; set; }
        public DbSet<tbl_000_USER> UserList { get; set; }
        public DbSet<tbl_000_USERGROUP> UserGroupList { get; set; }
        public DbSet<tbl_000_USERGROUP_MENUS> UserGroupMenuList { get; set; }
        public DbSet<tbl_000_SECTION> SectionList { get; set; }
        public DbSet<tbl_000_H_CATEGORY> CategoryList { get; set; }
        public DbSet<tbl_000_FXSP> FXSPList { get; set; }
        public DbSet<tbl_000_H_PART> ComponentList { get; set; }
        public DbSet<tbl_000_H_PI> PlasticInjectionList { get; set; }
        public DbSet<tbl_000_H_VP> VacuumPlatingList { get; set; }
        public DbSet<tbl_000_H_ASSY> AssymblyList { get; set; }
        public DbSet<tbl_000_H_ITEM> ItemList { get; set; }
        public DbSet<tbl_000_H_ITEM_PART> ItemPartList { get; set; }
        public DbSet<tbl_000_H_ITEM_TABULATION> ItemTabulationPIList { get; set; }
        public DbSet<tbl_000_H_ITEM_TABULATION_VP> ItemTabulationVPList { get; set; }
        public DbSet<tbl_000_H_ITEM_TABULATION_ASSY> ItemTabulationAssyList { get; set; }
        public DbSet<tbl_000_H_ITEM_MPT> ItemMPTList { get; set; }
        public DbSet<tbl_000_H_ITEM_FDC> ItemFDCList { get; set; }
        public DbSet<tbl_DEFAULT> DefaultList { get; set; }
        public DbSet<tbl_000_PROCESS> ProcessList { get; set; }
        public DbSet<tbl_SIGNATORY> SignatoryList { get; set; }
        public DbSet<tbl_tmp_300_H_STANDARD_COSTING_Q01_SUMMARY> tmp_StndardCostngSummList { get; set; }
        public DbSet<tbl_tmp_H_ITEM_PART> tmp_ItemPartList { get; set; }

        //WIP
        public DbSet<tbl_100_WIP> WIPList { get; set; }
        public DbSet<tbl_100_WIP_MT> WIPMTList { get; set; }
        public DbSet<tbl_000_MODRC> MODRCList { get; set; }
        public DbSet<tbl_100_WIP_Materials> WIPMaterialsList { get; set; }
        public DbSet<tbl_100_WIP_COSTING_LABOR_PI> WIPLaborPIList { get; set; }
        public DbSet<tbl_100_WIP_COSTING_LABOR_BAGG> WIPLaborBaggList { get; set; }
        public DbSet<tbl_100_WIP_COSTING_LABOR_ASSY> WIPLaborAssyList { get; set; }
        public DbSet<tbl_100_WIP_COSTING_LABOR_PLATED> WIPLaborPlatedList { get; set; }
    }
}
