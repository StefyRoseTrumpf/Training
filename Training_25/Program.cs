// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Custom MyList<T> class using arrays as the underlying data structure.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      var myList = new MyList<int> ();
      myList.Add (8);
      myList.Add (15);
      myList.Add (23);
      myList.Add (42);
      myList.Insert (2, 16);
      myList.Remove (15);
      myList.RemoveAt (0);
      myList[1] = 88;
      WriteLine ("Elements in MyList:");
      WriteLine ($"Count: {myList.Count} \nCapacity: {myList.Capacity}");
   }
}

// Custom generic list class
class MyList<T> {
   private T[] _items;
   private int _count;
   public MyList () {
      _items = new T[4];
      _count = 0;
   }

   // Properties to get count and capacity
   public int Count => _count;
   public int Capacity => _items.Length;

   // Indexer to access elements
   public T this[int index] {
      get {
         if (index < 0 || index >= _count) {
            throw new IndexOutOfRangeException ("Index out of range.");
         }
         return _items[index];
      }
      set {
         if (index < 0 || index >= _count) {
            throw new IndexOutOfRangeException ("Index out of range.");
         }
         _items[index] = value;
      }
   }

   // Add an item to the list
   public void Add (T a) {
      EnsureCapacity ();
      _items[_count++] = a;
   }

   // Remove an item from the list
   public bool Remove (T a) {
      int index = IndexOf (a);
      if (index == -1)
         return false;
      RemoveAt (index);
      return true;
   }

   // Clear the list
   public void Clear () {
      _items = new T[4];
      _count = 0;
   }

   // Insert an item at a specific index
   public void Insert (int index, T a) {
      if (index < 0 || index > _count)
         throw new ArgumentOutOfRangeException (nameof (index), "Invalid index for insert.");
      EnsureCapacity ();
      for (int i = _count; i > index; i--)
         _items[i] = _items[i - 1];
         _items[index] = a;
         _count++;
   }

   // Remove an item at a specific index
   public void RemoveAt (int index) {
      if (index < 0 || index >= _count) {
         throw new ArgumentOutOfRangeException (nameof (index), "Invalid index for remove.");
      }
      for (int i = index; i < _count - 1; i++)
         _items[i] = _items[i + 1];
      _count--;
      _items[_count] = default!;
   }

   // Ensure the internal array has enough capacity
   private void EnsureCapacity () {
      if ( _count >= _items.Length) {
         T[] newArray = new T[_items.Length * 2];
         Array.Copy (_items, newArray, _count);
         _items = newArray;
      }

   }

   // Find the index of an item
   private int IndexOf (T a) {
      for (int i = 0; i < _count; i++) {
         if (Equals (_items[i], a)) return i;
      }
      return -1;
   }

}
