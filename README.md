# CG_1

<div style="text-align:right">Рухович Игорь</div>
<div style="text-align:right">381808-1</div>

Отчёт по лабораторной работе №1. Обработка изображений.

Был создан абстрактный класс `Filter`, реализующий применение фильтра к изображению и содержащий:

- Функцию `protected virtual void DoPreprocessing(FastBitmap bmp)`, выполняющую предварительные рассчеты перед проходом по изображению
- Функцию `protected abstract Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)`, вызываемую в каждой точке изображения.

Исходное изображение выглядело так:

![](D:\Code\VS\NNSU\CG_1\saved_images\__unn.png)

На основе класса `Filter` были реализованы следующие точечные фильтры:

- Инверсия цветов: ![](D:\Code\VS\NNSU\CG_1\saved_images\unn_inversion.png)
- "Серый мир":![](D:\Code\VS\NNSU\CG_1\saved_images\unn_gray_world.png)
- Идеальный отражатель: (без изображения. Не получилось найти подходящее)
- Линейная коррекция: (без изображения. Не получилось найти подходящее)
- Поворот на 45 градусов против часовой стрелки:
- "Стекло":