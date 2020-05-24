# CG_1

<div style="text-align:right">Рухович Игорь</div>
<div style="text-align:right">381808-1</div>

Отчёт по лабораторной работе №1. Обработка изображений.

Все примеры будут продемонстрированы на данном исходном изображении:
<img src="saved_images/__unn.png" width="500px"> <img src="saved_images/__unn.png" width="500px">

Был создан абстрактный класс `Filter`, реализующий применение фильтра к изображению и содержащий:

- Функцию `protected virtual void DoPreprocessing(FastBitmap bmp)`, выполняющую предварительные расчеты перед проходом по изображению
- Функцию `protected abstract Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)`, вызываемую в каждой точке изображения.

На основе этого класса были реализованы несколько точечных фильтров, а именно 

Исходное изображение выглядело так:

![](saved_images/__unn.png)

На основе класса `Filter` были реализованы следующие точечные фильтры:

- Инверсия цветов: ![](saved_images/unn_inversion.png)
- "Серый мир":![](saved_images/unn_gray_world.png)
- Идеальный отражатель: (без изображения. Не получилось найти подходящее)
- Линейная коррекция: (без изображения. Не получилось найти подходящее)
- Поворот на 45 градусов против часовой стрелки:![](saved_images/unn_rotation.png)
- "Стекло":![](saved_images/unn_glass.png)
- Медианный фильтр:![](saved_images/unn_median.png)

Также на основе класса `Filter` был реализован класс `MatrixFilter`, с возможностью задания матрицы для расчёта нового пикселя. Были реализованы следующие матричные фильтры:

- Размытие:![](saved_images/unn_blur.png)
- Размытие по Гауссу:![](saved_images/unn_gaussian_blur.png)
- Тиснение:![](saved_images/unn_stamping.png)
- Светящиеся края:![](saved_images/unn_glowing_edges.png)

На основе класса `Filter` также реализован класс  `MorphologyFilter`, применяющий к изображению операции морфологии (наращивание, эрозию и их комбинации). Также присутствует возможность выбрать структурный элемент для операций морфологии (из графического изображения). Для следующих изображений использовался прямоугольник $3 \times 3$, полностью заполненный пикселями. Получились такие результаты:

- Наращивание:![](saved_images/unn_morph_full_dilation.png)
- Эрозия:![](saved_images/unn_morph_full_erosion.png)
- Размыкание (эрозия + наращивание):![](saved_images/unn_morph_full_opening.png)
- Замыкание (наращивание + эрозия):![](saved_images/unn_morph_full_closure.png)
- Морфологический градиент (наращивание - эрозия):![](saved_images/unn_morph_full_gradient.png)
- Морфологический градиент + замыкание:![](saved_images/unn_morph_full_gradient_closure.png)

Лучше всего различия в структурном элементе видно на изображениях с градиентом:

- Градиент при структурном, с закрашенным прямоугольником $1 \times 3$:![](saved_images/unn_morph_updown_gradient.png)
- Градиент при структурном элементе с закрашенным прямоугольником $1 \times 2$ (центральный и нижний пиксели):![](saved_images/unn_morph_down_gradient.png)

И, напоследок, картинка, получившаяся в результате экспериментов (фильтр светящихся границ, чередующийся с тиснением). Что-то похожее на неоновую вывеску:![](saved_images/unn_neon.png)