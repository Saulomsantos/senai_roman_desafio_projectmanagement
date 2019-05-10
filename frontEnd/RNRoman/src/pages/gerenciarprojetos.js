import React, { Component } from 'react';
import { AsyncStorage, Text, View, StyleSheet, FlatList } from 'react-native';
import api from '../services/api';

class GerenciarProjetos extends Component {
    constructor(props) {
        super(props);
        this.state = {
            listaProjetos: [],
            token: ""
        }
    }

    _BuscarDados = async () => {
        try {
            console.warn("Buscar Dados comecou")
          const value = await AsyncStorage.getItem('userToken');
          if (value !== null) {
            this.setState({ token: value });
          }
        } catch (error) {}

        this._carregaProjetos();
        console.warn("Buscar Dados foi")
        console.warn(this.state.token)
      };
    
    _carregaProjetos = async () => {
        console.warn("Carregar Projetos Comecou")
        const resposta = await api.get("/Projetos", {
            headers: {
                'Authorization' : 'Bearer ' + (this.state.token)
            }
        }
        );
        const dadosApi = resposta.data
        this.setState({listaProjetos: dadosApi})
        console.warn("Carregar Projetos foi")
    }

    componentDidMount() {
        this._BuscarDados();
        console.warn("Opa")
    }
    
    render() {
        return (
            <View style={styles.container}>
                <Text style={paddingTop= 15}>{"Projetos".toUpperCase()}</Text>
                <FlatList
                    contentContainerStyle={styles.ConteudoLista}
                    data={this.state.listaProjetos}
                    keyExtractor={item => item.id}
                    renderItem={this.renderizaItem}
                />
            </View>
        )
    }

    renderizaItem = ({ item }) => (
        <View style={styles.flatItemSeparador}>
            <View style={styles.flatItemContainer}>
                <Text style={styles.flatItemLinha}>{item.id} - {item.nome}</Text>
            </View>
        </View>
      );
}

export default GerenciarProjetos;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
    // linha de separacao do cabecalho
    mainHeaderLine: {
        width: 170,
        paddingTop: 10,
        borderBottomColor: "#999999",
        borderBottomWidth: 0.9
    },
    // conteúdo da lista
    ConteudoLista: {
    paddingTop: 30,
    paddingRight: 50,
    paddingLeft: 50
  },
    // dados do evento de cada item da linha
    flatItemSeparador: {
    flexDirection: "row",
    borderBottomWidth: 0.9,
    borderBottomColor: "gray",
    marginBottom: 10
  },
});