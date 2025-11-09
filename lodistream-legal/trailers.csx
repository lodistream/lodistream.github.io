import com.lagradost.cloudstream3.*
import com.lagradost.cloudstream3.utils.*

class Trailers : MainAPI() {
    override var mainUrl = "https://www.youtube.com"
    override var name = "Trailers"
    override val supportedTypes = setOf(TvType.Movie, TvType.TvSeries)
    override var lang = "tr"
    override val hasMainPage = true

    override suspend fun getMainPage(): HomePageResponse {
        val items = listOf(
            MovieSearchResponse("Dune: Bölüm 2 Fragmanı", "$mainUrl/watch?v=n9xhJrPXop4", name, TvType.Movie),
            MovieSearchResponse("Napoleon Fragmanı", "$mainUrl/watch?v=COv52Qyctws", name, TvType.Movie),
            MovieSearchResponse("Oppenheimer Fragmanı", "$mainUrl/watch?v=uYPbbksJxIg", name, TvType.Movie)
        )
        return newHomePageResponse("Yeni Fragmanlar", items)
    }
}