# DeleteNode

- We check to see if the first node is the one with the data that we want to delete, then we set runner.Next to null.
- If it isn't the head, we iterate through and set runner to runner.Next.
- Once we've found the node we want to delete, we set the walker to runner.Next and runner.Next to walker.Next. Then we set walker.Next to null, and it is deleted.