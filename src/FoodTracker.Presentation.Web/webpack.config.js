const { VueLoaderPlugin } = require("vue-loader");
const { CleanWebpackPlugin } = require("clean-webpack-plugin");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const autoprefixer = require("autoprefixer");
const path = require("path");

module.exports = {
    mode: "development",
    entry: "./ClientApp/main.ts",
    output: {
        path: path.resolve(__dirname, "./wwwroot/js/"),
        publicPath: "/wwwroot/js/"
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: "vue-loader",
            },
            {
                test: /\.(eot|ttf|woff|woff2)(\?\S*)?$/,
                loader: "file-loader",
                options: {
                    name: "[name][contenthash:8].[ext]",
                },
            },
            {
                test: /\.(png|jpe?g|gif|webm|mp4|svg)$/,
                loader: "file-loader",
                options: {
                    outputPath: "assets",
                    esModule: false,
                },
            },
            {
                test: /\.s?css$/,
                use: [
                    "style-loader",
                    MiniCssExtractPlugin.loader,
                    "css-loader",
                    {
                        loader: "postcss-loader",
                        options: {
                            plugins: () => [autoprefixer()],
                        },
                    },
                    "sass-loader",
                ],
            },
        ],
    },
    plugins: [
        new VueLoaderPlugin(),
        new MiniCssExtractPlugin(),
        new CleanWebpackPlugin(),
    ],
    resolve: {
        alias: {
            vue$: "vue/dist/vue.esm-bundler.js",
        },
        extensions: ["*", ".js", ".vue", ".json", ".ts"],
    }
};