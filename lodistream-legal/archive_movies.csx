import com.lagradost.cloudstream3.*

class ArchiveMovies : MainAPI() {
    override var mainUrl = "https://archive.org"
    override var name = "Archive Movies"
    override val supportedTypes = setOf(TvType.Movie)
    override val hasMainPage = true
    override var lang = "en"

    override suspend fun getMainPage(): HomePageResponse {
        val classics = listOf(
            MovieSearchResponse("Night of the Living Dead (1968)", "$mainUrl/details/night_of_the_living_dead", name, TvType.Movie),
            MovieSearchResponse("His Girl Friday (1940)", "$mainUrl/details/his_girl_friday", name, TvType.Movie),
            MovieSearchResponse("The General (1926)", "$mainUrl/details/TheGeneral", name, TvType.Movie)
        )
        return newHomePageResponse("Public Domain Classics", classics)
    }
}