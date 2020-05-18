# CG_1

<div style="text-align:right">Рухович Игорь</div>
<div style="text-align:right">381808-1</div>

Отчёт по лабораторной работе №1. Обработка изображений.

Был создан абстрактный класс `Filter`, реализующий применение фильтра к изображению и содержащий:

- Функцию `protected virtual void DoPreprocessing(FastBitmap bmp)`, выполняющую предварительные расчеты перед проходом по изображению
- Функцию `protected abstract Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)`, вызываемую в каждой точке изображения.

Исходное изображение выглядело так:

![](saved_images/__unn.png)

На основе класса `Filter` были реализованы следующие точечные фильтры:

- Инверсия цветов: ![](saved_images/unn_inversion.png)

- "Серый мир":![](saved_images/unn_gray_world.png)

- Идеальный отражатель: (без изображения. Не получилось найти подходящее)

- Линейная коррекция: (без изображения. Не получилось найти подходящее)

- Поворот на 45 градусов против часовой стрелки:![](saved_images/unn_rotation.png)

- "Стекло":![](saved_images/unn_glass.png)

Также на основе класса `Filter` был реализован класс `MatrixFilter`, с возможностью задания матрицы для расчёта нового пикселя. Были реализованы следующие матричные фильтры:

- Размытие:![](saved_images/unn_blur.png)
- Размытие по Гауссу:![](saved_images/unn_gaussian_blur.png)
- Тиснение:![](saved_images/unn_stamping.png)
- Светящиеся края:![](saved_images/unn_glowing_edges.png)

