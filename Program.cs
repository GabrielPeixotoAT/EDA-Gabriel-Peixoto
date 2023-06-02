using EDA_Gabriel_Peixoto.Applications;
using EDA_Gabriel_Peixoto.Applications.GUI;
using EDA_Gabriel_Peixoto.Arvore;
using EDA_Gabriel_Peixoto.Lista;
using EDA_Gabriel_Peixoto.Pilha;

int index = 0;
IApplication? application;

List<string> options = new List<string> { "Stack", "List", "Tree" };
IGUIFactory guiFactory = new SelectionMenu(options, 15);

 while (index != options.Count() -1)
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
        case 2:
            application = new ApplicationTree();
            break;
        default:
            application = null;
            break;
    }

    if (application != null)
        application.Run();

}   