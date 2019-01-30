using UnityEngine;

public class Fruit
{
    private string _name;
    private Vector3 _location;
    private float _weight;

    public Fruit(string name, Vector3 location, float weight)
    {
        this._name = name;
        this._location = location;
        this._weight = weight;
    }

    // properties
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public float LocationAtX 
    {
        get { return _location.x; }
    }

    public float LocationAtY
    {
        get { return _location.y; }
    }

    public float LocationAtZ
    {
        get { return _location.z; }
    }

    public Vector3 Location
    {
        get { return _location;}
    }

    public bool IsLocationSet
    {
        get {
            return _location != Vector3.zero;
        }
    }

    // methods
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        this._name = name;
    }
}