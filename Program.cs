using EDA_Gabriel_Peixoto.Applications;
using EDA_Gabriel_Peixoto.Applications.GUI;
using EDA_Gabriel_Peixoto.Lista;
using EDA_Gabriel_Peixoto.Pilha;

int index = 0;
IApplication? application = null;
IGUIFactory guiFactory = new SelectionMenu(new List<string> { "Stack", "List" }, 15);

 while (index != 2)
 {
    index = guiFactory.BuildMenu();
    switch (index)
    {
        case 0:
            application = new ApplicationStack();
            break;
        case 1:
            application = new ApplicationList();
            break;
        default:
            application = null;
            break;
    }

    if (application != null)
        application.Run();

}   