using Castle.MicroKernel.Registration;
using Castle.Windsor;

private void button1_Click(object sender, EventArgs e)
{
    // CREATE A WINDSOR CONTAINER OBJECT AND REGISTER THE INTERFACES, AND THEIR CONCRETE IMPLEMENTATIONS.
    var container = new WindsorContainer();
    container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary1.Main>());
    container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary1.IDependency1>().ImplementedBy<ClassLibrary1.Dependency1>());
    container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary1.IDependency2>().ImplementedBy<ClassLibrary1.Dependency2>());

    // CREATE THE MAIN OBJECT AND INVOKE ITS METHOD(S) AS DESIRED.
    var mainThing = container.Resolve<ClassLibrary1.Main>();
    mainThing.DoSomething();
}