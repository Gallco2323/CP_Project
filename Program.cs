using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("CI/CD Pipeline Simulation Started\n");

        DownloadPhase();
        BuildPhase();
        ImageBuildPhase();
        DeploymentPhase();

        Console.WriteLine("\nCI/CD Pipeline Simulation Finished");
    }

    static void DownloadPhase()
    {
        Console.WriteLine("=== Download Phase Started ===");

        Thread t1 = new Thread(DownloadLibraries);
        Thread t2 = new Thread(DownloadOSImage);
        Thread t3 = new Thread(DownloadJavaImage);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("=== Download Phase Completed ===\n");
    }

    static void BuildPhase()
    {
        Console.WriteLine("=== Build Phase Started ===");

        Thread t1 = new Thread(BuildMicroserviceA);
        Thread t2 = new Thread(BuildMicroserviceB);
        Thread t3 = new Thread(BuildMicroserviceC);
        Thread t4 = new Thread(BuildMicroserviceD);

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        t4.Join();

        Console.WriteLine("=== Build Phase Completed ===\n");
    }

    static void ImageBuildPhase()
    {
        Console.WriteLine("=== Image Build Phase Started ===");

        Thread t1 = new Thread(BuildImage);
        Thread t2 = new Thread(CompileConfiguration);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("=== Image Build Phase Completed ===\n");
    }

    static void DeploymentPhase()
    {
        Console.WriteLine("=== Deployment Phase Started ===");

        Thread t1 = new Thread(DeployMicroserviceA);
        Thread t2 = new Thread(DeployMicroserviceB);
        Thread t3 = new Thread(DeployMicroserviceC);
        Thread t4 = new Thread(DeployMicroserviceD);

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        t4.Join();

        Console.WriteLine("=== Deployment Phase Completed ===\n");
    }

    static void DownloadLibraries()
    {
        Console.WriteLine("Downloading Libraries...");
        Thread.Sleep(1000);
        Console.WriteLine("Libraries downloaded.");
    }

    static void DownloadOSImage()
    {
        Console.WriteLine("Downloading OS Image...");
        Thread.Sleep(1200);
        Console.WriteLine("OS Image downloaded.");
    }

    static void DownloadJavaImage()
    {
        Console.WriteLine("Downloading Java Image...");
        Thread.Sleep(1100);
        Console.WriteLine("Java Image downloaded.");
    }

    static void BuildMicroserviceA()
    {
        Console.WriteLine("Building Microservice A...");
        Thread.Sleep(1500);
        Console.WriteLine("Microservice A built.");
    }

    static void BuildMicroserviceB()
    {
        Console.WriteLine("Building Microservice B...");
        Thread.Sleep(1300);
        Console.WriteLine("Microservice B built.");
    }

    static void BuildMicroserviceC()
    {
        Console.WriteLine("Building Microservice C...");
        Thread.Sleep(1400);
        Console.WriteLine("Microservice C built.");
    }

    static void BuildMicroserviceD()
    {
        Console.WriteLine("Building Microservice D...");
        Thread.Sleep(1250);
        Console.WriteLine("Microservice D built.");
    }

    static void BuildImage()
    {
        Console.WriteLine("Building Image...");
        Thread.Sleep(1000);
        Console.WriteLine("Image built.");
    }

    static void CompileConfiguration()
    {
        Console.WriteLine("Compiling Configuration...");
        Thread.Sleep(900);
        Console.WriteLine("Configuration compiled.");
    }

    static void DeployMicroserviceA()
    {
        Console.WriteLine("Deploying Microservice A...");
        Thread.Sleep(1000);
        Console.WriteLine("Microservice A deployed.");
    }

    static void DeployMicroserviceB()
    {
        Console.WriteLine("Deploying Microservice B...");
        Thread.Sleep(1000);
        Console.WriteLine("Microservice B deployed.");
    }

    static void DeployMicroserviceC()
    {
        Console.WriteLine("Deploying Microservice C...");
        Thread.Sleep(1000);
        Console.WriteLine("Microservice C deployed.");
    }

    static void DeployMicroserviceD()
    {
        Console.WriteLine("Deploying Microservice D...");
        Thread.Sleep(1000);
        Console.WriteLine("Microservice D deployed.");
    }
}
