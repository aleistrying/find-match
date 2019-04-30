if (files != null && files.Count > 0)
                {
                    foreach (var file in files)
                    {
                    if (file.Name.ToLower().StartsWith("pci") == true)
                    {
                        Regex rx = new Regex(@"(d/).+(/)");
                        MatchCollection matches = rx.Matches(file.WebViewLink);

                        foreach (Match match in matches)
                        {

                            fixedMatch = match.Value;

                            /*
                            char[] fixedMatchArr = fixedMatch.ToCharArray();
                            fixedMatchArr[0] = ' ';
                            fixedMatchArr[1] = ' ';
                            fixedMatchArr[(fixedMatchArr.Count() - 1)] = ' ';
                            fixedMatch = "";
                            foreach(char charac in fixedMatchArr)
                            {
                                fixedMatch += charac;
                            }
                            fixedMatch = fixedMatch.Replace(" ", ""); */


                            Regex reg = new Regex(@"(d/)|(/)");
                            string pattern = @"";

                            fixedMatch = reg.Replace(match.Value, pattern);
                            if (file.Name.EndsWith(".xlsx") || file.Name.EndsWith(".xls") || file.Name.EndsWith(".csv"))
                            {
                                System.Diagnostics.Process.Start(
                                    "https://drive.google.com/uc?authuser=0&id=" 
                                    + fixedMatch 
                                    + "&export=download");//"https://docs.google.com/spreadsheets/d/" + fixedMatch + "/export?format=xlsx");

                            }
                            else if(file.Name.EndsWith(""))
                            {
                                System.Diagnostics.Process.Start(
                                "https://docs.google.com/feeds/download/spreadsheets/Export?key="
                                + fixedMatch + "&exportFormat=xlsx");
                            }
                            continue;

                            //MessageBox.Show(file.Name);
                            //downloadFile(fixedMatch, service, file.Name);
                            


                        }
                    }

                }
                }
                else
                {
                } 
