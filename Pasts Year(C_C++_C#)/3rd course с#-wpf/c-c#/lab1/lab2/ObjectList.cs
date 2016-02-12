using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace lab2
{
    class ObjectList<T> : BindingList<T>
        {

            private bool sorted = false;
            private ListSortDirection sort_direction = ListSortDirection.Ascending;
            private PropertyDescriptor sort_property = null;

            protected override bool SupportsSearchingCore
            {
                get { return true; }
            }

            protected override bool SupportsSortingCore
            {
                get { return true; }
            }

            protected override bool IsSortedCore
            {
                get { return sorted; }
            }


            protected override ListSortDirection SortDirectionCore
            {
                get { return sort_direction; }
            }

            protected override PropertyDescriptor SortPropertyCore
            {
                get { return sort_property; }
            }

            protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
            {
                sort_direction = direction;
                sort_property = prop;
                ObjectSortComparer<T> comparer = new ObjectSortComparer<T>(prop, direction);
                ApplySortInternal(comparer);
            }

            private void ApplySortInternal(ObjectSortComparer<T> comparer)
            {
                List<T> listRef = this.Items as List<T>;
                if (listRef == null)
                    return;

                listRef.Sort(comparer);
                sorted = true;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }

    }
class ObjectSortComparer<T> : IComparer<T>
{
    private PropertyDescriptor property_descriptor = null;
    private ListSortDirection direction = ListSortDirection.Ascending;

    public ObjectSortComparer(PropertyDescriptor propDesc, ListSortDirection d)
    {
        property_descriptor = propDesc;
        direction = d;
    }

    int IComparer<T>.Compare(T x, T y)
    {
        object xValue = property_descriptor.GetValue(x);
        object yValue = property_descriptor.GetValue(y);
        return CompareValues(xValue, yValue, direction);
    }

    private int CompareValues(object xValue, object yValue, ListSortDirection d)
    {
        int retValue = 0;
        if (xValue is IComparable) //can ask the x value
        {
            retValue = ((IComparable)xValue).CompareTo(yValue);
        }
        else if (yValue is IComparable) //can ask the y value
        {
            retValue = ((IComparable)yValue).CompareTo(xValue);
        }

        else if (!xValue.Equals(yValue))
        {
            retValue = xValue.ToString().CompareTo(yValue.ToString());
        }
        if (d == ListSortDirection.Ascending)
            return retValue;
        else
            return retValue * -1;

    }

} 

