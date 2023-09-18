
class Program
{
    static void Main(string[] args)
    {
        ComputerBuilder builder;

        var store = new PCStore();

        builder = new GamingComputerBuilder();

        var gamingComputer = store.Construct(builder);

        builder = new DevelopmentComputerBuilder();

        var developmentComputer = store.Construct(builder);

        Console.WriteLine($"Gaming computer: {gamingComputer.CPU}, {gamingComputer.GPU}, {gamingComputer.Ram}, {gamingComputer.Disk}");
        Console.WriteLine($"Development computer: {developmentComputer.CPU}, {developmentComputer.GPU}, {developmentComputer.Ram}, {developmentComputer.Disk}");

        Console.ReadKey();
    }
}

/// <summary>
/// The director class
/// </summary>
class PCStore
{
    public Computer Construct(ComputerBuilder builder)
    {
        builder.SetCPU();
        builder.SetGPU();
        builder.SetRAM();
        builder.SetDisk();

        return builder.Computer;
    }
}

/// <summary>
/// The abstract builder class
/// </summary>
abstract class ComputerBuilder
{
    public Computer Computer { get; protected set; }

    public abstract void SetCPU();

    public abstract void SetGPU();

    public abstract void SetRAM();

    public abstract void SetDisk();
}

/// <summary>
/// Concrete builder class
/// </summary>
class GamingComputerBuilder : ComputerBuilder
{
    public GamingComputerBuilder()
    {
        Computer = new Computer();
    }

    public override void SetCPU()
    {
        Computer.CPU = "Intel i9 9900K";
    }

    public override void SetGPU()
    {
        Computer.GPU = "Nvidia RTX 2080 Ti";
    }

    public override void SetRAM()
    {
        Computer.Ram = "32 GB";
    }

    public override void SetDisk()
    {
        Computer.Disk = "1 TB SSD";
    }
}

/// <summary>
/// Concrete builder class
/// </summary>
class DevelopmentComputerBuilder : ComputerBuilder
{
    public DevelopmentComputerBuilder()
    {
        Computer = new Computer();
    }

    public override void SetCPU()
    {
        Computer.CPU = "Intel i11 11900K";
    }

    public override void SetGPU()
    {
        Computer.GPU = "Onboard";
    }

    public override void SetRAM()
    {
        Computer.Ram = "128 GB";
    }

    public override void SetDisk()
    {
        Computer.Disk = "512 GB SSD";
    }
}

/// <summary>
/// The product class
/// </summary>
class Computer
{
    public string CPU { get; set; }

    public string GPU { get; set; }

    public string Disk { get; set; }

    public string Ram { get; set; }
}