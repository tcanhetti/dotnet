using Projeto.filehelper;

namespace Projeto.models
{
    public class Contagem{
        public void CountdownForTextFile(string path, int counter){
            FileHelper helper = new FileHelper();
            string finalText = "";
            
            for(int i = 1; i <= counter; i++){
                finalText = String.Concat(finalText, i, "\n");
            }
            helper.CreateTextFile(path, finalText);
        }
    }
}