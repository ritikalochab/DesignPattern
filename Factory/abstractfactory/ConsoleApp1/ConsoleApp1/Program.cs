public interface Button
{
    void renderButton();
}
public interface ScrollBar
{
    void renderScrollBar();
}

public class WindowButton : Button
{
    public void renderButton()
    {
        Console.WriteLine("windows button");
    }
}

public class MacButton : Button
{
    public void renderButton()
    {
        Console.WriteLine("mac button");
    }
}

public class WindowScrollbar : ScrollBar
{
    public void renderScrollBar()
    {
        Console.WriteLine("window scrollbar");
    }
}
public class MacScrollBar : ScrollBar
{
    public void renderScrollBar()
    {
        Console.WriteLine("mac scrollbar");
    }

}


public interface AbstractFactory
{
    public Button createButton();
    public ScrollBar createScrollbar();
}

public class WindowFactory : AbstractFactory
{
    public Button createButton()
    {
        return new WindowButton();
    }

    public ScrollBar createScrollbar()
    {
        return new WindowScrollbar();
    }
}

public class MacFactory : AbstractFactory
{
    public Button createButton()
    {
        return new MacButton();
    }

    public ScrollBar createScrollbar()
    {
        return new MacScrollBar();
    }
}

public class Application
{
    public Button button;
    public ScrollBar scrollBar; 
   public Application(AbstractFactory fac)
    {
        button= fac.createButton(); 
        scrollBar= fac.createScrollbar();   
    }

    public void renderUi()
    {
        button.renderButton();
        scrollBar.renderScrollBar();
    }
}
public class Solution
{
    public static void Main(string[] args)
    {
        AbstractFactory w = new WindowFactory();
        Application app = new Application(w);
        app.renderUi();

        AbstractFactory m = new MacFactory();
        Application app1 = new Application(m);
        app1.renderUi();

    }
}

