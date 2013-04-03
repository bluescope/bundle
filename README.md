bundle
======
  
This is only a proof-of-concept demonstration. 

Making efficient bundles saves money which enables the business to stay efficient and provide the most value at the best price to our valued customers. Builders have to spend less time sorting huge items on site which helps save time, avoid costly mistakes, and keep projects on time. Meeting deadlines is critical because our customers rely on us to deliver on time.

Every order has a list of items. We take the list of items and sort and bundle them according to specific rules. The parts are usually custom fabricated to best address the unique opportunities and challenges that come with every project, there are sophisticated, specific rules for sorting and bundling. It makes sense to keep track of the logic with the help of a computer. 

Let's look at our workflow. What is the result that we are going after? We would like each item to have a mark which tells our manufacturing and shipping team that a particular item belongs to a particular bundle. What information do we have? We have information on a bunch of items which have an order number in common among them.  We also have a list of rules. Rules take the type, material, physical dimensions, color, and many other points into consideration to come up with the best way to sort and bundle items.

We have a collection of items. We have a collection of rules. When we get an order number as input, we use that order number to query our database for items matching that order number. We get a collection of items with various properties for every item. We look for a specific property which I call ItemType. For most items, this is enough information to start processing the bundling operation. However, a few items require a more fine-tuned approach. Let's see if we can accomodate that in our code. 
