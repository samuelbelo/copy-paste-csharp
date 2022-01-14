public class SimpleFileCopy
{
    static void Main()
    {

        string cnpj = "10224870409000127";

        StreamReader re = File.OpenText("C:\\Users\\Samuel\\Documents\\e1000001.txt");
        string input = re.ReadToEnd();

        if (input.IndexOf(cnpj) > -1)
        {
            Console.WriteLine(cnpj + " existe");
            string fileName = "e1000001.txt";
            string sourcePath = "C:\\Users\\Samuel\\Documents\\";
            string targetPath = "C:\\Users\\Samuel\\Documents\\Pasta Que Vai Copiar o CNPJ";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder.
            // If the directory already exists, this method does not create a new directory.
            Directory.CreateDirectory(targetPath);

            // To copy a file to another location and
            // overwrite the destination file if it already exists.
            File.Copy(sourceFile, destFile, true);
        }
            
        else
        {
            Console.WriteLine(cnpj + " nao existe");
        }

        re.Close();

        

        // To copy all the files in one directory to another directory.
        // Get the files in the source folder. (To recursively iterate through
        // all subfolders under the current directory, see
        // "How to: Iterate Through a Directory Tree.")
        // Note: Check for target path was performed previously
        //       in this code example.
        
        /*
        if (System.IO.Directory.Exists(sourcePath))
        {
            string[] files = System.IO.Directory.GetFiles(sourcePath);

            // Copy the files and overwrite destination files if they already exist.
            foreach (string s in files)
            {
                // Use static Path methods to extract only the file name from the path.
                fileName = System.IO.Path.GetFileName(s);
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(s, destFile, true);
            }
        }
        else
        {
            Console.WriteLine("Source path does not exist!");
        }*/

        Console.WriteLine("pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}