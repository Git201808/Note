# 20200528 Java面象对象之ArrayBox封装

## 数组

数组是开发者创建好的类型

数组是一个小容器 存储一组元素

添加元素 获取元素 删除元素

1. 创建一个数组对象																1.创建一个ArrayBox对象

   `int[] array = new int[10];`										`ArrayBox box = new ArrayBox();`

2. 添加元素                                                                                2.添加元素

   `array[0] = 10; `                                                                  `box.add(10);`

3. 获取元素

   `int value = array[0];`

4. 遍历

   ```
   for(int i = 0;i<array.length;i++){
   	array[i];
   }
   ```

   