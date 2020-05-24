# CG_1

<div style="text-align:right">Рухович Игорь</div>
<div style="text-align:right">381808-1</div>

Отчёт по лабораторной работе №1. Обработка изображений.

Был создан абстрактный класс `Filter`, реализующий применение фильтра к изображению и содержащий:

- Функцию `protected virtual void DoPreprocessing(FastBitmap bmp)`, выполняющую предварительные расчеты перед проходом по изображению
- Функцию `protected abstract Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)`, вызываемую в каждой точке изображения.

На основе этого класса были реализованы несколько точечных фильтров, а именно

- Инверсия цветов:

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_inversion.png" width="400px">
- "Серый мир":

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_gray_world.png" width="400px">
- Линейная коррекция:

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_linear_stretching.png" width="400px">
- Поворот на 45 градусов против часовой стрелки:

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_rotation.png" width="400px">
- "Стекло":

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_glass.png" width="400px">
- Медианный фильтр. Для создания изображения берутся значения только из красного канала, для каждого пикселя берутся все значения в заданном радиусе и выбирается (за O(n)) медиана. Затем медианное значение записывается во все каналы:

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_median.png" width="400px">

Также на основе класса `Filter` был реализован класс `MatrixFilter`, с возможностью задания матрицы (в конструкторе) для расчёта нового пикселя. Были реализованы следующие матричные фильтры:

- Размытие. Эффект практически незаметен на большом изображении:

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_blur.png" width="400px">
- Размытие по Гауссу. Эффект намного более заметен:

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_gaussian_blur.png" width="400px">
- Тиснение (для более чёткой видимости к данной картинке применён фильтр линейного растяжения после тиснения):

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_stamping_lin_str.png" width="400px">
- Светящиеся края (выделение контуров + фильтр максимума; реализованы одним фильтром):

<img src="saved_images/__lena.png" width="400px"><img src="saved_images/lena_glowing_edges.png" width="400px">
- Медианный фильтр + светящиеся края. На изображении намного меньше шума, но теряются 2 других цветовых канала:

<img src="saved_images/lena_median.png" width="400px"><img src="saved_images/lena_median_glowing_edges.png" width="400px">

На основе класса `Filter` также реализован класс  `MorphologyFilter`, применяющий к изображению операции морфологии (наращивание, эрозию и их комбинации). Для этого сначала изображение приводится к бинарному с помощью такой команды `binaryImage[x, y] = col.R <= 127 && col.G <= 127 && col.B > 127`, затем выполняется операция морфологии и в результате выводится изображение, где белый цвет означает `false`, а синий - `true`. Тут структурный элемент - это прямоугольник $3 \times 3$:

- Наращивание:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_full_dilation.png" width="800px">
- Эрозия:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_full_erosion.png" width="800px">
- Размыкание (эрозия + наращивание):

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_full_opening.png" width="800px">
- Замыкание (наращивание + эрозия):

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_full_closure.png" width="800px">
- Морфологический градиент:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_full_gradient.png" width="800px">

Также присутствует возможность выбрать структурный элемент для операций морфологии. Для этого необходимо подать на вход программе изображение в любом формате, высота и ширина которого не превышают 7 пикселей. Оно будет преобразовано к бинарному по следующему условию `structElement[x, y] = color.R == 0`. Лучше всего различия в структурном элементе видно при применении операции морфологического градиента:

- Структурный элемент - прямоугольник $3 \times 3$, размеры фигуры -  $3 \times 3$:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_full_gradient.png" width="800px">
- Структурный элемент - прямоугольник $1 \times 3$, но размеры фигуры -  $3 \times 3$:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_updown_gradient.png" width="800px">
- Структурный элемент - прямоугольник $1 \times 2$ (центральный и нижний пиксели), но размеры фигуры -  $3 \times 3$:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_morph_down_gradient.png" width="800px">

И, напоследок, картинка, получившаяся в результате экспериментов (фильтр светящихся границ, чередующийся с тиснением). Что-то похожее на неоновую вывеску:

<img src="saved_images/__unn.png" width="800px"><img src="saved_images/unn_neon.png" width="800px">