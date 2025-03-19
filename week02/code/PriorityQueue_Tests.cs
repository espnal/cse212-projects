// using Microsoft.VisualStudio.TestTools.UnitTesting;

// // TODO Problem 2 - Write and run test cases and fix the code to match requirements.

// [TestClass]
// public class PriorityQueueTests
// {
//     [TestMethod]
//     // Scenario: Insert a single element and then remove it.
//     // Expected Result: The only inserted element should be returned.
//     // Defects Found: None expected.
//     public void TestSingleEnqueueDequeue()
//     {
//         var priorityQueue = new PriorityQueue();
//         priorityQueue.Enqueue("A", 1);
//         Assert.AreEqual("A", priorityQueue.Dequeue());
//     }

//     [TestMethod]
//     // Scenario: Insert multiple elements with different priorities.
//     // Expected Result: The element with the highest priority is removed first.
//     // Defects Found: Possible error in index selection.
//     public void TestDequeueHighestPriority()
//     {
//         var priorityQueue = new PriorityQueue();
//         priorityQueue.Enqueue("A", 1);
//         priorityQueue.Enqueue("B", 3);
//         priorityQueue.Enqueue("C", 2);
//         Assert.AreEqual("B", priorityQueue.Dequeue());
//     }

//         [TestMethod]
//     // Scenario: Insert elements with the same priority.
//     // Expected Result: FIFO for elements with the same priority.
//     // Defects Found: Possible failure in removal order.
//     public void TestFIFOForSamePriority()
//     {
//         var priorityQueue = new PriorityQueue();
//         priorityQueue.Enqueue("A", 2);
//         priorityQueue.Enqueue("B", 2);
//         priorityQueue.Enqueue("C", 2);
//         Assert.AreEqual("A", priorityQueue.Dequeue());
//         Assert.AreEqual("B", priorityQueue.Dequeue());
//         Assert.AreEqual("C", priorityQueue.Dequeue());
//     }
// }