


// ---------------------------------------------------------------------------------------------
class Program {
static TableServers host1List = TableServers.GetTableServers();
static TableServers host2List = TableServers.GetTableServers();

    static void Main(string[] args){
        TableServers servers = TableServers.GetTableServers();

        for (int i = 0; i < 5; i++)
        {
            Host1GetNextServer();
            Host2GetNextServer();
        }

        Console.ReadLine();
    }

    private static void Host1GetNextServer(){
        System.Console.WriteLine($"Host 1: The next server is: {host1List.GetNextServer()}");
    }
    private static void Host2GetNextServer(){
        System.Console.WriteLine($"Host 2: The next server is: {host2List.GetNextServer()}");
    }
}

// ---------------------------------------------------------------------------------------------

// Singleton Upload Service
// Thread t1 = new Thread(() => {
//     var instance = UploadService.GetInstance(1);
// });

// Thread t2 = new Thread(() => {
//     var instance = UploadService.GetInstance(2);
// });

// t1.Start();
// t2.Start();

// t1.Join();
// t2.Join();

// ---------------------------------------------------------------------------------------------