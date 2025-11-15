namespace Generics
{
    public class ListGeneric<T>
    {
        private T[] _items = new T[4];
        private int _size = 0;

        public void Add(T item)
        {
            if (_size >= _items.Length)
            {
                var newItems = new T[_items.Length * 2];
                Array.Copy(_items, newItems, _items.Length);
                _items = newItems;
            }

            _items[_size] = item;
            _size++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _size)
            {
                throw new IndexOutOfRangeException(
                    $"Index {index} is out of range."
                    );
            }

            --_size;

            for (int i = index; i < _size; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_size] = default!;
        }

        public T GetAtIndex(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException(
                    $"Index {index} is out of range."
                    );
            }

            return _items[index];
        }

        public T[] GetAllItems()
        {
            var result = new T[_size];

            Array.Copy(_items, result, _size);

            return result;
        }
    }
}
