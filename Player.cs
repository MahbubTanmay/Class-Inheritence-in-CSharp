class LocalPlayer
{
    public int health = 100; //accessable from another class
    private int damage = 10; //not accessable from another class

    private int speed = 7;



    public void setHealth(int a) //to change the value of int health from another class
    {
        health = a;
    }


    public int getDamage() //this will make int damage accessable from another class
    {
        return damage;
    }




    private int getSpeed() //This method is not accessable as it is private
    {
        return speed;
    }


}
