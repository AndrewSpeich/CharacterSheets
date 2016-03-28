using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class savehandler
    {
        
        public savehandler()
        {
          
        }

        private List<string> checkoverwrite(string check)
        {
            List<string> newlist = new List<string>();
          
            System.IO.StreamReader fileread = new System.IO.StreamReader("../Character Sheet.char", true);

            List<string> fullfile = System.IO.File.ReadAllLines("../Character Sheet.char").ToList<string>();
            fileread.Close();
            for(int index = fullfile.Count-1; 0<= index; index--)
            {
                if(!fullfile[index].Substring(0, check.Length).Contains(check))
                {
                    newlist.Add(fullfile[index]);
                }
            }
            return newlist;
        }
        public void savestuff( List<String> savedata)
        {
            
            if (savedata[0].Contains("&") || savedata[0].Contains("#") || savedata[0].Contains("%"))
            {
                savedata[0] = savedata[0].Replace('%', ' ');
                savedata[0] = savedata[0].Replace('#', ' ');
                savedata[0] = savedata[0].Replace('&', ' ');
            }
            savedata[0] = "##" + savedata[0];
           

         
            string saveline = "";
           
            foreach (string data in savedata)
              {
                saveline = saveline + data;
                saveline = saveline + "&";
             }
            List<string> writelist = checkoverwrite(savedata[0]);
            writelist.Add(saveline);
            System.IO.File.WriteAllText("Character Sheet.char", "");
            System.IO.StreamWriter file = new System.IO.StreamWriter("../Character Sheet.char", false);
            
            foreach (string line in writelist)
            {
                file.WriteLine(line);
                
               
            }
            file.Close();
        }
        public List<String> getsaves()
        {
            
            System.IO.StreamWriter filewrite = new System.IO.StreamWriter("../Character Sheet.char", true);
            filewrite.Close();
            System.IO.StreamReader file = new System.IO.StreamReader("../Character Sheet.char", true);
            List<String> savelist = new List<String>();

            List<String> savefile = new List<String>();

            savefile = System.IO.File.ReadAllLines("../Character Sheet.char").ToList<string>();
           foreach(string name in savefile)
            {
                savelist.Add(name.Remove(0, 2).Substring(0, name.IndexOf("&")-2));
            }
            savelist.Add("Character Saves");
            file.Close();
            return savelist;
        }

        public List<String> loadstuff(string savename)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("../Character Sheet.char", true);
            List<String> savedata = new List<String>();
          
        


            string fullfile = String.Concat(System.IO.File.ReadAllLines("../Character Sheet.char"));

            savename = "##" + savename;
            List<String> loadedfiles = System.IO.File.ReadAllLines("../Character Sheet.char").ToList<string>();
            foreach(string character in loadedfiles)
            {
                if (character.Contains(savename))
                {
                   string loadinfo = character.Remove(0, 2);
                    while(loadinfo.Length>2)
                    {
                        savedata.Add(loadinfo.Substring(0, loadinfo.IndexOf("&")));
                        loadinfo = loadinfo.Remove(0, loadinfo.IndexOf("&") + 1);
                    }

                    break;
                }
            }
            file.Close();
            return savedata;
        }
    }
}
