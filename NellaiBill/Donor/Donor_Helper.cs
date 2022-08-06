using NellaiBill.Models.Donor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Donor
{
    public class Donor_Helper
    {
        public List<string> donorNames = new List<string>();
        public List<string> donorAddress = new List<string>();
        public string GetDonorFilterQry()
        {
            DatabaseConnection xDb = new DatabaseConnection();
            string xFilterQry = "";
            DonorSettingsModel donorSettingsModelResponse = new DonorSettingsModel();
            donorSettingsModelResponse = xDb.GetDonorSettingsBasedOnQry(1);

            xFilterQry += donorSettingsModelResponse.DonorAnnual == 1 ? " and donor_annual=" + donorSettingsModelResponse.DonorAnnual : "";
            xFilterQry += donorSettingsModelResponse.DonorEndowment == 1 ? "  and donor_endowment = " + donorSettingsModelResponse.DonorAnnual : "";
            xFilterQry += donorSettingsModelResponse.DonorThings == 1 ? "  and donor_things = " + donorSettingsModelResponse.DonorThings : "";
            xFilterQry += donorSettingsModelResponse.DonorWelfare == 1 ? "  and donor_welfare = " + donorSettingsModelResponse.DonorWelfare : "";
            xFilterQry += donorSettingsModelResponse.SupportCS == 1 ? "  and support_cs = " + donorSettingsModelResponse.SupportCS : "";
            xFilterQry += donorSettingsModelResponse.SupportFS == 1 ? "  and support_fs = " + donorSettingsModelResponse.SupportFS : "";
            xFilterQry += donorSettingsModelResponse.SupportBS == 1 ? "  and support_bs = " + donorSettingsModelResponse.SupportBS : "";
            xFilterQry += donorSettingsModelResponse.SupportCloth == 1 ? "  and support_cloth = " + donorSettingsModelResponse.SupportCloth : "";
            xFilterQry += donorSettingsModelResponse.SupportOther == 1 ? "  and support_other = " + donorSettingsModelResponse.SupportOther : "";
            xFilterQry += donorSettingsModelResponse.SROOC == 1 ? "  and sr_ooc = " + donorSettingsModelResponse.SROOC : "";
            xFilterQry += donorSettingsModelResponse.SRNTC == 1 ? "  and sr_ntc = " + donorSettingsModelResponse.SRNTC : "";
            xFilterQry += donorSettingsModelResponse.SRPost == 1 ? "  and sr_post = " + donorSettingsModelResponse.SRPost : "";
            xFilterQry += donorSettingsModelResponse.SRVisitor == 1 ? "  and sr_visitor = " + donorSettingsModelResponse.SRVisitor : "";
            xFilterQry += donorSettingsModelResponse.SREmail == 1 ? "  and sr_email = " + donorSettingsModelResponse.SREmail : "";
            xFilterQry += donorSettingsModelResponse.GreetingsPongal == 1 ? "  and greetings_pongal = " + donorSettingsModelResponse.GreetingsPongal : "";
            xFilterQry += donorSettingsModelResponse.GreetingsEaster == 1 ? "  and greetings_easter = " + donorSettingsModelResponse.GreetingsEaster : "";
            xFilterQry += donorSettingsModelResponse.GreetingsChristmas == 1 ? "  and greetings_christmas = " + donorSettingsModelResponse.GreetingsChristmas : "";
            xFilterQry += donorSettingsModelResponse.GreetingsOthers == 1 ? "  and greetings_others = " + donorSettingsModelResponse.GreetingsOthers : "";
            return xFilterQry;
        }
    }

  
}
