using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW080223
{
    internal class Vector<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }

        public Vector() { }
        public Vector(T a) { 
            X = a;
            Y = a;
            Z = a;
        }
        public Vector(T a, T b, T c)
        {
            X = a;
            Y = b;
            Z = c;
        }
        public void Input()
        {
            Console.WriteLine("Enter the value for X:");
            X = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Преобразует string в <T>
            Console.WriteLine("Enter the value for Y:");
            Y = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Преобразует string в <T>
            Console.WriteLine("Enter the value for Z:");
            Z = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Преобразует string в <T>
        }
        public void Output()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Z = {Z}");
        }
        public T Length()
        {
            return (T)Convert.ChangeType(Math.Sqrt(Math.Pow(Convert.ToDouble(X), 2) + Math.Pow(Convert.ToDouble(Y), 2) + Math.Pow(Convert.ToDouble(Z), 2)), typeof(T));
        }
        public static Vector<T> operator +(Vector<T> a, Vector<T> b)
        {
            if (!(a.X is IComparable) || !(a.Y is IComparable) || !(a.Z is IComparable)) // На случай, если dynamic не поддержывает <T>
            {
                throw new InvalidOperationException("Type T must be IComparable in order to use the + operator.");
            }
            dynamic dX = a.X, dy = a.Y, dz = a.Z;
            dX += b.X;
            dy += b.Y;
            dz += b.Z;
            return new Vector<T>((T)dX, (T)dy, (T)dz);
        }
        public static Vector<T> operator +(Vector<T> a, T b)
        {
            if (!(a.X is IComparable) || !(a.Y is IComparable) || !(a.Z is IComparable)) // На случай, если dynamic не поддержывает <T>
            {
                throw new InvalidOperationException("Type T must be IComparable in order to use the + operator.");
            }
            dynamic dX = a.X, dy = a.Y, dz = a.Z;
            dX += b;
            dy += b;
            dz += b;
            return new Vector<T>((T)dX, (T)dy, (T)dz);
        }
        public static Vector<T> operator -(Vector<T> a, Vector<T> b)
        {
            if (!(a.X is IComparable) || !(a.Y is IComparable) || !(a.Z is IComparable)) // На случай, если dynamic не поддержывает <T>
            {
                throw new InvalidOperationException("Type T must be IComparable in order to use the + operator.");
            }
            dynamic dX = a.X, dy = a.Y, dz = a.Z;
            dX -= b.X;
            dy -= b.Y;
            dz -= b.Z;
            return new Vector<T>((T)dX, (T)dy, (T)dz);
        }
        public static Vector<T> operator -(Vector<T> a, T b)
        {
            if (!(a.X is IComparable) || !(a.Y is IComparable) || !(a.Z is IComparable)) // На случай, если dynamic не поддержывает <T>
            {
                throw new InvalidOperationException("Type T must be IComparable in order to use the + operator.");
            }
            dynamic dX = a.X, dy = a.Y, dz = a.Z;
            dX -= b;
            dy -= b;
            dz -= b;
            return new Vector<T>((T)dX, (T)dy, (T)dz);
        }
        public static Vector<T> operator *(Vector<T> a, Vector<T> b)
        {
            if (!(a.X is IComparable) || !(a.Y is IComparable) || !(a.Z is IComparable)) // На случай, если dynamic не поддержывает <T>
            {
                throw new InvalidOperationException("Type T must be IComparable in order to use the + operator.");
            }
            dynamic dX = a.X, dy = a.Y, dz = a.Z;
            dX *= b.X;
            dy *= b.Y;
            dz *= b.Z;
            return new Vector<T>((T)dX, (T)dy, (T)dz);
        }

        public static bool operator ==(Vector<T> a, Vector<T> b)
        {
            return a.X.GetHashCode() == b.X.GetHashCode();
        }
        public static bool operator !=(Vector<T> a, Vector<T> b)
        {
            return a.X.GetHashCode() != b.X.GetHashCode();
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
    }
}
