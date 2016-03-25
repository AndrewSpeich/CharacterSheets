using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        savehandler storage = new savehandler();
        NumberPropogate math = new NumberPropogate();
        List<TextBox> alltextboxes = new List<TextBox>();
        List<TextBox> strength = new List<TextBox>();
        List<TextBox> dexterity = new List<TextBox>();
        List<TextBox> constitution = new List<TextBox>();
        List<TextBox> intelligence = new List<TextBox>();
        List<TextBox> wisdom = new List<TextBox>();
        List<TextBox> charisma = new List<TextBox>();
        List<TextBox> skillacrobatics = new List<TextBox>();
        List<TextBox> skillappraise = new List<TextBox>();
        List<TextBox> skillbluff = new List<TextBox>();
        List<TextBox> skillclimb = new List<TextBox>();
        List<TextBox> skillcraft = new List<TextBox>();
        List<TextBox> skillcraft2 = new List<TextBox>();
        List<TextBox> skillcraft3 = new List<TextBox>();
        List<TextBox> skilldiplomacy = new List<TextBox>();
        List<TextBox> skilldisabledevice = new List<TextBox>();
        List<TextBox> skilldisguise = new List<TextBox>();
        List<TextBox> skillescapeartist = new List<TextBox>();
        List<TextBox> skillfly = new List<TextBox>();
        List<TextBox> skillhandleanimal = new List<TextBox>();
        List<TextBox> skillheal = new List<TextBox>();
        List<TextBox> skillintimidate = new List<TextBox>();
        List<TextBox> skillarcana = new List<TextBox>();
        List<TextBox> skilldungeoneering = new List<TextBox>();
        List<TextBox> skillengineering = new List<TextBox>();
        List<TextBox> skillgeography = new List<TextBox>();
        List<TextBox> skillhistory = new List<TextBox>();
        List<TextBox> skilllocal = new List<TextBox>();
        List<TextBox> skillnature = new List<TextBox>();
        List<TextBox> skillnobility = new List<TextBox>();
        List<TextBox> skillplanes = new List<TextBox>();
        List<TextBox> skillreligion = new List<TextBox>();
        List<TextBox> skilllinguistics = new List<TextBox>();
        List<TextBox> skillperception = new List<TextBox>();
        List<TextBox> skillperform = new List<TextBox>();
        List<TextBox> skillperform2 = new List<TextBox>();
        List<TextBox> skillprofession = new List<TextBox>();
        List<TextBox> skillprofession2 = new List<TextBox>();
        List<TextBox> skillride = new List<TextBox>();
        List<TextBox> skillsensemotive = new List<TextBox>();
        List<TextBox> skillsleightofhand = new List<TextBox>();
        List<TextBox> skillspellcraft = new List<TextBox>();
        List<TextBox> skillstealth = new List<TextBox>();
        List<TextBox> skillsurvival = new List<TextBox>();
        List<TextBox> skillswim = new List<TextBox>();
        List<TextBox> skillusemagicdevice = new List<TextBox>();

        List<TextBox> acarmor = new List<TextBox>();
        List<TextBox> toucharmor = new List<TextBox>();
        List<TextBox> flatarmor = new List<TextBox>();
        List<TextBox> initiativecheck = new List<TextBox>();
        List<List<TextBox>> skills = new List<List<TextBox>>();

        List<TextBox> fortitude = new List<TextBox>();
        List<TextBox> reflex = new List<TextBox>();
        List<TextBox> will = new List<TextBox>();
        List<List<TextBox>> saves = new List<List<TextBox>>();

        List<TextBox> cmdef = new List<TextBox>();
        List<TextBox> cmbon = new List<TextBox>();
        List<List<TextBox>> combatman = new List<List<TextBox>>();

        List<TextBox> usesbab = new List<TextBox>();

        List<TextBox> fortsave = new List<TextBox>();
        List<TextBox> refsave = new List<TextBox>();
        List<TextBox> willsave = new List<TextBox>();
        List<List<TextBox>> saveslist = new List<List<TextBox>>();




        public Form1()
        {
            InitializeComponent();

             makeskilllist();
             makeskillsa2h();
             makeskillsi2l();
             makeskillsp2u();
             makestatmodlists();
             makearmorlist();
             makebablist();
             makecombatmanlist();
             makesaveslists();
             addallthetextboxes();
            populatedropbar();

        }
        void makearmorlist()
        {
            acarmor.Add(armorclass);
            acarmor.Add(dexarmor);
            acarmor.Add(armorbonus);
            acarmor.Add(shieldbonus);
            acarmor.Add(naturalarmor);
            acarmor.Add(deflectionmod);
            acarmor.Add(armorten);
            acarmor.Add(sizemod);
            acarmor.Add(miscmod);

            toucharmor.Add(toucharmorclass);
            toucharmor.Add(armorten);
            toucharmor.Add(dexarmor);
            toucharmor.Add(deflectionmod);

            flatarmor.Add(flatfootedac);
            flatarmor.Add(armorten);
            flatarmor.Add(armorbonus);
            flatarmor.Add(shieldbonus);
            flatarmor.Add(naturalarmor);
            flatarmor.Add(deflectionmod);
            flatarmor.Add(sizemod);
            flatarmor.Add(miscmod);

        }
        void makestatmodlists()
        {
            strength.Add(strmod);
            strength.Add(strcmd);
            strength.Add(strcmb);
            strength.Add(strclimb);
            strength.Add(strswim);

            dexterity.Add(dexmod);
            dexterity.Add(dexacrobatics);
            dexterity.Add(dexarmor);
            dexterity.Add(dexcmd);
            dexterity.Add(dexdisabledevice);
            dexterity.Add(dexescapeartist);
            dexterity.Add(dexfly);
            dexterity.Add(dexinit);
            dexterity.Add(dexreflex);
            dexterity.Add(dexride);
            dexterity.Add(dexsleightofhand);
            dexterity.Add(dexstealth);

            constitution.Add(conmod);
            constitution.Add(confort);

            intelligence.Add(intmod);
            intelligence.Add(intappraise);
            intelligence.Add(intcraft);
            intelligence.Add(intcraft2);
            intelligence.Add(intcraft3);
            intelligence.Add(intarcana);
            intelligence.Add(intdungeoneering);
            intelligence.Add(intengineering);
            intelligence.Add(intgeography);
            intelligence.Add(inthistory);
            intelligence.Add(intlocal);
            intelligence.Add(intnature);
            intelligence.Add(intnobility);
            intelligence.Add(intplanes);
            intelligence.Add(intreligion);
            intelligence.Add(intlinguistics);
            intelligence.Add(intspellcraft);

            wisdom.Add(wismod);
            wisdom.Add(wisheal);
            wisdom.Add(wiswill);
            wisdom.Add(wisperception);
            wisdom.Add(wisprofession);
            wisdom.Add(wisprofession2);
            wisdom.Add(wissensemotive);
            wisdom.Add(wissurvival);

            charisma.Add(chamod);
            charisma.Add(chabluff);
            charisma.Add(chadiplomacy);
            charisma.Add(chadisguise);
            charisma.Add(chahandleanimal);
            charisma.Add(chaintimidate);
            charisma.Add(chaperform);
            charisma.Add(chaperform2);
            charisma.Add(chausemagicdevice);


        }
        void makeskilllist()
        {
            skills.Add(skillacrobatics);
            skills.Add(skillappraise);
            skills.Add(skillbluff);
            skills.Add(skillclimb);
            skills.Add(skillcraft);
            skills.Add(skillcraft2);
            skills.Add(skillcraft3);
            skills.Add(skilldiplomacy);
            skills.Add(skilldisabledevice);
            skills.Add(skilldisguise);
            skills.Add(skillescapeartist);
            skills.Add(skillfly);
            skills.Add(skillhandleanimal);
            skills.Add(skillheal);
            skills.Add(skillintimidate);
            skills.Add(skillarcana);
            skills.Add(skilldungeoneering);
            skills.Add(skillengineering);
            skills.Add(skillgeography);
            skills.Add(skillhistory);
            skills.Add(skilllocal);
            skills.Add(skillnature);
            skills.Add(skillnobility);
            skills.Add(skillplanes);
            skills.Add(skillreligion);
            skills.Add(skilllinguistics);
            skills.Add(skillperception);
            skills.Add(skillperform);
            skills.Add(skillperform2);
            skills.Add(skillprofession);
            skills.Add(skillprofession2);
            skills.Add(skillride);
            skills.Add(skillsensemotive);
            skills.Add(skillsleightofhand);
            skills.Add(skillspellcraft);
            skills.Add(skillstealth);
            skills.Add(skillsurvival);
            skills.Add(skillswim);
            skills.Add(skillusemagicdevice);
        }

        void makeskillsa2h()
        {
            skillacrobatics.Add(acrobatics);
            skillacrobatics.Add(dexacrobatics);
            skillacrobatics.Add(acrobaticsranks);
            skillacrobatics.Add(acrobaticsmisc);

            skillappraise.Add(appraise);
            skillappraise.Add(intappraise);
            skillappraise.Add(appraiseranks);
            skillappraise.Add(appraisemisc);

            skillbluff.Add(bluff);
            skillbluff.Add(chabluff);
            skillbluff.Add(bluffranks);
            skillbluff.Add(bluffmisc);


            skillclimb.Add(climb);
            skillclimb.Add(strclimb);
            skillclimb.Add(climbranks);
            skillclimb.Add(climbmisc);


            skillcraft.Add(craft);
            skillcraft.Add(intcraft);
            skillcraft.Add(craftranks);
            skillcraft.Add(craftmisc);


            skillcraft2.Add(craft2);
            skillcraft2.Add(intcraft2);
            skillcraft2.Add(craft2ranks);
            skillcraft2.Add(craft2misc);

            skillcraft3.Add(craft3);
            skillcraft3.Add(intcraft3);
            skillcraft3.Add(craft3ranks);
            skillcraft3.Add(craft3misc);

            skilldiplomacy.Add(diplomacy);
            skilldiplomacy.Add(chadiplomacy);
            skilldiplomacy.Add(diplomacyranks);
            skilldiplomacy.Add(diplomacymisc);

            skilldisabledevice.Add(disabledevice);
            skilldisabledevice.Add(dexdisabledevice);
            skilldisabledevice.Add(disabledeviceranks);
            skilldisabledevice.Add(disabledevicemisc);

            skilldisguise.Add(disguise);
            skilldisguise.Add(chadisguise);
            skilldisguise.Add(disguiseranks);
            skilldisguise.Add(disguisemisc);

            skillescapeartist.Add(escapeartist);
            skillescapeartist.Add(dexescapeartist);
            skillescapeartist.Add(escapeartistranks);
            skillescapeartist.Add(escapeartistmisc);

            skillfly.Add(fly);
            skillfly.Add(dexfly);
            skillfly.Add(flyranks);
            skillfly.Add(flymisc);

            skillhandleanimal.Add(handleanimal);
            skillhandleanimal.Add(chahandleanimal);
            skillhandleanimal.Add(handleanimalranks);
            skillhandleanimal.Add(handleanimalmisc);

            skillheal.Add(heal);
            skillheal.Add(wisheal);
            skillheal.Add(healranks);
            skillheal.Add(healmisc);

        }

        void makeskillsi2l()
        {

            skillintimidate.Add(intimidate);
            skillintimidate.Add(chaintimidate);
            skillintimidate.Add(intimidateranks);
            skillintimidate.Add(intimidatemisc);

            skillarcana.Add(arcana);
            skillarcana.Add(intarcana);
            skillarcana.Add(arcanaranks);
            skillarcana.Add(arcanamisc);

            skilldungeoneering.Add(dungeoneering);
            skilldungeoneering.Add(intdungeoneering);
            skilldungeoneering.Add(dungeoneeringranks);
            skilldungeoneering.Add(dungeoneeringmisc);

            skillengineering.Add(engineering);
            skillengineering.Add(intengineering);
            skillengineering.Add(engineeringranks);
            skillengineering.Add(engineeringmisc);

            skillgeography.Add(geography);
            skillgeography.Add(intgeography);
            skillgeography.Add(geographyranks);
            skillgeography.Add(geographymisc);

            skillhistory.Add(history);
            skillhistory.Add(inthistory);
            skillhistory.Add(historyranks);
            skillhistory.Add(historymisc);

            skilllocal.Add(local);
            skilllocal.Add(intlocal);
            skilllocal.Add(localranks);
            skilllocal.Add(localmisc);

            skillnature.Add(nature);
            skillnature.Add(intnature);
            skillnature.Add(natureranks);
            skillnature.Add(naturemisc);

            skillnobility.Add(nobility);
            skillnobility.Add(intnobility);
            skillnobility.Add(nobilityranks);
            skillnobility.Add(nobilitymisc);

            skillplanes.Add(planes);
            skillplanes.Add(intplanes);
            skillplanes.Add(planesranks);
            skillplanes.Add(planesmisc);

            skillreligion.Add(religion);
            skillreligion.Add(intreligion);
            skillreligion.Add(religionranks);
            skillreligion.Add(religionmisc);

            skilllinguistics.Add(linguistics);
            skilllinguistics.Add(intlinguistics);
            skilllinguistics.Add(linguisticsranks);
            skilllinguistics.Add(linguisticsmisc);


        }

        void makeskillsp2u()
        {

            skillperception.Add(perception);
            skillperception.Add(wisperception);
            skillperception.Add(perceptionranks);
            skillperception.Add(perceptionmisc);

            skillperform.Add(perform);
            skillperform.Add(chaperform);
            skillperform.Add(performranks);
            skillperform.Add(performmisc);

            skillperform2.Add(perform2);
            skillperform2.Add(chaperform2);
            skillperform2.Add(perform2ranks);
            skillperform2.Add(perform2misc);

            skillprofession.Add(profession);
            skillprofession.Add(wisprofession);
            skillprofession.Add(professionranks);
            skillprofession.Add(professionmisc);

            skillprofession2.Add(profession2);
            skillprofession2.Add(wisprofession2);
            skillprofession2.Add(profession2ranks);
            skillprofession2.Add(profession2misc);

            skillride.Add(ride);
            skillride.Add(dexride);
            skillride.Add(rideranks);
            skillride.Add(ridemisc);

            skillsensemotive.Add(sensemotive);
            skillsensemotive.Add(wissensemotive);
            skillsensemotive.Add(sensemotiveranks);
            skillsensemotive.Add(sensemotivemisc);

            skillsleightofhand.Add(sleightofhand);
            skillsleightofhand.Add(dexsleightofhand);
            skillsleightofhand.Add(sleightofhandranks);
            skillsleightofhand.Add(sleightofhandmisc);

            skillspellcraft.Add(spellcraft);
            skillspellcraft.Add(intspellcraft);
            skillspellcraft.Add(spellcraftranks);
            skillspellcraft.Add(spellcraftmisc);

            skillstealth.Add(stealth);
            skillstealth.Add(dexstealth);
            skillstealth.Add(stealthranks);
            skillstealth.Add(stealthmisc);

            skillsurvival.Add(survival);
            skillsurvival.Add(wissurvival);
            skillsurvival.Add(survivalranks);
            skillsurvival.Add(survivalmisc);

            skillswim.Add(swim);
            skillswim.Add(strswim);
            skillswim.Add(swimranks);
            skillswim.Add(swimmisc);

            skillusemagicdevice.Add(usemagicdevice);
            skillusemagicdevice.Add(chausemagicdevice);
            skillusemagicdevice.Add(usemagicdeviceranks);
            skillusemagicdevice.Add(usemagicdevicemisc);


        }

        void makebablist()
        {
            usesbab.Add(cmbbab);
            usesbab.Add(cmdbab);
        }
        void makecombatmanlist()
        {

            cmbon.Add(cmb);
            cmbon.Add(cmbbab);
            cmbon.Add(cmbsize);
            cmbon.Add(strcmb);

            cmdef.Add(cmd);
            cmdef.Add(cmdbab);
            cmdef.Add(cmdsize);
            cmdef.Add(cmdten);
            cmdef.Add(strcmd);
            cmdef.Add(dexcmd);

            combatman.Add(cmbon);
            combatman.Add(cmdef);
        }

        void makesaveslists()
        {
            saveslist.Add(fortsave);
            saveslist.Add(refsave);
            saveslist.Add(willsave);

            fortsave.Add(fortbonus);
            fortsave.Add(classfort);
            fortsave.Add(confort);
            fortsave.Add(fortmagic);
            fortsave.Add(fortmisc);
            fortsave.Add(forttemp);

            refsave.Add(reflexbonus);
            refsave.Add(classreflex);
            refsave.Add(dexreflex);
            refsave.Add(magicref);
            refsave.Add(miscref);
            refsave.Add(reftemp);

            willsave.Add(willbonus);
            willsave.Add(classwill);
            willsave.Add(wiswill);
            willsave.Add(magicwill);
            willsave.Add(miscwill);
            willsave.Add(tempwill);
        }

        void addallthetextboxes()
        {

            IEnumerable<Control> controllist = getAllTextBoxes(this);
          
            foreach (TextBox index in controllist)
            {
             
                    alltextboxes.Add(index);
                
            }

        }
        IEnumerable<Control> getAllTextBoxes(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.AddRange(getAllTextBoxes(c));
                if (c is TextBox)
                {
                    controlList.Add(c);
                }

            }
            return controlList;
        }

        void populatedropbar()
        {
            saveholder.Items.Clear();
            foreach(String text in storage.getsaves())
           saveholder.Items.Add(  text );
        }

        
        private void strstat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int str = int.Parse(strstat.Text);
            }
            catch
            {

            }
            math.setmod(strength, strstat);
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
            foreach (List<TextBox> usebab in combatman)
            {
                math.addUp(usebab);
            }
        }

        private void dexstat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int dex = int.Parse(dexstat.Text);
            }
            catch
            {

            }
            math.setmod(dexterity, dexstat);
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
            foreach (List<TextBox> usebab in combatman)
            {
                math.addUp(usebab);
            }
        }

        private void constat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int con = int.Parse(constat.Text);
            }
            catch
            {

            }
            math.setmod(constitution, constat);
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
        }

        private void intstat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int inti = int.Parse(intstat.Text);
            }
            catch
            {

            }
            math.setmod(intelligence, intstat);
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
        }

        private void wisstat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int wis = int.Parse(wisstat.Text);
            }
            catch
            {

            }
            math.setmod(wisdom, wisstat);
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
        }

        private void chastat_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int cha = int.Parse(chastat.Text);
            }
            catch
            {

            }
            math.setmod(charisma, chastat);
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            foreach (List<TextBox> skill in skills)
            {
                math.addUp(skill);
            }

        }

        private void bab_TextChanged(object sender, EventArgs e)
        {
            foreach (TextBox usebab in usesbab)
            {
                int babnum = 0;
                try
                {
                     babnum = int.Parse(bab.Text);
                }
                catch
                {

                }
                usebab.Text = babnum.ToString();
            }
            foreach (List<TextBox> usebab in combatman)
            {
                math.addUp(usebab);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string savename = saveholder.Text;
            List<string> info = new List<string>();
            info.Add(savename);
            foreach(TextBox text in alltextboxes)
            {
                info.Add(text.Text);
            }



            storage.savestuff(info);
            populatedropbar();

        }

        private void load_Click(object sender, EventArgs e)
        {
            List<string> loaded = new List<string>();
            loaded = storage.loadstuff(saveholder.Text);

            loaded.RemoveAt(0);
            int index = 0;
            foreach(string load in loaded)
            {
                alltextboxes[index].Text = load;
                index++;
            }
            populatedropbar();
        }

        private void featsspellsequimentpage_Click(object sender, EventArgs e)
        {

        }
    }
    
}
