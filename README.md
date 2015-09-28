# Special purpose Priority Queue using Generics

FixedLengthPriorityQueue is a generic Priority Queue that can grow to a maximum length.
Typically used when you need to maintain a Top 10 list. Intended to be used in cases 
where the length is small. Its generic so it can be used with any data type or abstract 
data types. A custom comparison function for determining priority is actually required.

RestrictedPriorityQueue is similar to the FixedLengthPriorityQueue. Except, it allows
the queue to grow beyond the 'full' state if the items being added have the same priority
as the lowest priority item on the queue. For example, a Top 5 queue, maintains a queue of 
numbers with the highest priority being the lowest value number. If the list contains the
values 1, 3, 6, 7, 8 and a new value of 8 is added the queue will now contain two eights
at the bottom of the queue 1, 3, 6, 7, 8, 8 as such the list now contains 6 elements 
instead of 5. Add another 8 and the list grows again. Now add a 5 and the list is cut 
short to five elements again : 1, 3, 5, 6, 7 and all the eights are removed because they
no longer have sufficient priority.