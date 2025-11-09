import com.lagradost.cloudstream3.*

class Documentaries : MainAPI() {
    override var mainUrl = "https://www.documentaryheaven.com"
    override var name = "Documentaries"
    override val supportedTypes = setOf(TvType.Movie)
    override val hasMainPage = true
    override var lang = "en"

    override suspend fun getMainPage(): HomePageResponse {
        val docs = listOf(
            MovieSearchResponse("The Secrets of Nature", "$mainUrl/the-secrets-of-nature", name, TvType.Movie),
            MovieSearchResponse("The Ocean Depths", "$mainUrl/the-ocean-depths", name, TvType.Movie)
        )
        return newHomePageResponse("Popular Documentaries", docs)
    }
}