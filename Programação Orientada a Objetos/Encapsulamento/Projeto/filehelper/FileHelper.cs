namespace Projeto.filehelper{
    public class FileHelper{
        public void CreateDirectory(string path){
            var result = Directory.CreateDirectory(path);
            System.Console.WriteLine(result.FullName);
        }

        public void CreateTextFile(string path, string content){   
            if(!File.Exists(path)){
                File.WriteAllText(path, content);
            }
        }

        public void CreateStreamTextFile(string path, List<string> content){
            using(var stream = File.CreateText(path)){
                foreach(var line in content){
                    stream.WriteLine(line);
                }
            }
        }

        public void AddNewText(string path, string content){
            File.AppendAllText(path, content);
        }

        public void AddNewStreamText(string path, List<string> content){
            using(var stream = File.AppendText(path)){
                foreach(var line in content){
                    stream.WriteLine(line);
                }
            }
        }
    }
}